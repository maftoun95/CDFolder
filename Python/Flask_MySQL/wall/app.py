
#NOTE: MY USER TABLE IS CALLED wall_users.

#NOTE TO SELF: SET THE REQUIRED SESSION VARS FOR ID AND FIRST NAME ON REG

#import required moduels
import re
from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import MySQLConnector
from flask.ext.bcrypt import Bcrypt
app = Flask(__name__)
#define regex statements
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')
#set up bcrypt and mysql
bcrypt = Bcrypt(app)
mysql = MySQLConnector(app, 'mydb')
#define secret key
app.secret_key = "singlyLinkedFist"

@app.route('/')
def index():
	return render_template('index.html')

@app.route('/reghandler', methods=['POST'])
def signup():
	errors = 0
#if errors, increment the errors var by 1 && flash the appropriate err msg
	if len(request.form['first_name']) < 2:
		errors += 1
		flash('needs more characters in first name')
	if not NAME_REGEX.match(request.form['first_name']):
		errors += 1
		flash('no numbers allowed in first name')
	if len(request.form['last_name']) < 2:
		errors += 1
		flash('needs more characters in last name')
	if not NAME_REGEX.match(request.form['last_name']):
		errors += 1
		flash('no numbers allowed in last name')
	if not EMAIL_REGEX.match(request.form['email']):
		errors +=1
		flash('invalid email')
	if len(request.form['password']) <=9:
		errors +=1
		flash('password must be at least 9 characters long')
	if request.form['password'] != request.form['confirm']:
		errors +=1
		flash('passwords do not match')
	#ADD ERROR VALIDATION FOR ONLY ONE EMAIL IN THE DB
#if no errors have been hit, set up the session and go to the wall
	if errors == 0:
		query = "INSERT INTO wall_users (first_name, last_name, email, pw_hash, created_at, updated_at) VALUES (:first_name, :last_name, :email, :pw_hash, NOW(), NOW())"
		password = request.form['password']
		pw_hash = bcrypt.generate_password_hash(password)
		data = {
			'first_name' : request.form['first_name'],
			'last_name' : request.form['last_name'],
			'email' : request.form['email'],
			'pw_hash' : pw_hash
		}
		USERid = mysql.query_db(query, data)
		#set appropriate session vars
		session['Id'] = USERid
		session['user_id'] = request.form['first_name']
		return redirect('/wall')
#else, if errors have been met, redirect to home route and flash errors
	elif errors > 0:
		return redirect('/register')

#handle the redirect in case of errors on the home route
@app.route('/register')
def reroute():
	return render_template('index.html')

#go to the wall
@app.route('/wall')
def wall():
	query = 'SELECT messages.id, messages.content, messages.created_at, wall_users.id, wall_users.first_name, wall_users.last_name FROM messages JOIN wall_users ON wall_users.id = messages.wall_user_id ORDER BY messages.created_at DESC'
	#set messageData to the result of our sql query
	messageData = mysql.query_db(query)
	otherQuery = "SELECT comments.message_id, comments.comment, comments.created_at, wall_users.first_name, wall_users.last_name FROM comments JOIN wall_users ON wall_users.id = comments.wall_user_id"
	#set commentData to the result of our sql query
	commentData = mysql.query_db(otherQuery)
	#render the wall, pass messages && comments
	return render_template('wall.html', messages=messageData, comments = commentData)

#make the handler for the login form
@app.route('/login', methods=['POST'])
def login():
	#pull email and p/w from the form for later use
	email = request.form['email']
	password = request.form['password']
	query = 'SELECT id, email, pw_hash, first_name FROM wall_users WHERE email = "{}"'.format(email)
	#set result to the result of my query
	result = mysql.query_db(query)
	#if the email is not in the bd... flash err msg and redirect
	if len(result) < 1:
		flash("Email not found")
		return redirect('/')
	#if the provided p/w matches the associated email in our db... start the session and route to the wall
	if bcrypt.check_password_hash(result[0]['pw_hash'], password):
		session['Id'] = result[0]['id']
		session['user_id'] = result[0]['first_name']
		return redirect('/wall')
	#else, flass err msg and redirect
	else:
		flash('Incorrect Password')
		return redirect('/')
	#in case no previous redirect occurs, redirect to home
	return redirect('/')

#submit messages to db
@app.route("/post", methods=['POST'])
def post():
	query = 'INSERT INTO messages (content, created_at, updated_at, wall_user_id) VALUES (:content, NOW(), NOW(), :wall_user_id)'
	data = {
		'content': request.form['message'],
		'wall_user_id': session['Id']
	}
	mysql.query_db(query, data)
	return redirect('/wall')

#submit message comments to db
@app.route('/comment/<message_id>', methods=['post'])
def comment(message_id):
	query = 'INSERT INTO comments (comment, created_at, updated_at, wall_user_id, message_id) VALUES (:comment, NOW(), NOW(), :wall_user_id, :message_id)'
	data = {
		'comment': request.form['comment'],
		'wall_user_id': session['Id'],
		'message_id': message_id
	}
	mysql.query_db(query, data)
	return redirect('/wall')

#set handler to log current user out by clearing session variables
@app.route('/logout')
def logout():
	session.clear()
	return redirect('/')

#run our flask app
app.run(debug=True)