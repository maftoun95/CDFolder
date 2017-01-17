import re
from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import MySQLConnector
from flask.ext.bcrypt import Bcrypt
app = Flask(__name__)
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')
bcrypt = Bcrypt(app)
mysql = MySQLConnector(app, 'mydb')
app.secret_key = "singlyLinkedFist"

@app.route('/')
def index():
	return render_template('index.html')

@app.route('/reghandler', methods=['POST'])
def signup():
	errors = 0

	if len(request.form['first_name']) < 2:
		errors += 1
		flash('needs more characters in first name')
	elif not NAME_REGEX.match(request.form['first_name']):
		errors += 1
		flash('no numbers allowed in first name')
	if len(request.form['last_name']) < 2:
		errors += 1
		flash('needs more characters in last name')
	elif not NAME_REGEX.match(request.form['last_name']):
		errors += 1
		flash('no numbers allowed in last name')
	if not EMAIL_REGEX.match(request.form['email']):
		errors +=1
		flash('invalid email')
	if len(request.form['password']) <9:
		errors +=1
		flash('password must be at least 9 characters long')
	if request.form['password'] != request.form['confirm']:
		errors +=1
		flash('passwords do not match')

	if errors == 0:
		query = "INSERT INTO wall_users (first_name, last_name, email, pw_hash, created_at, updated_at) VALUES (:first_name, :last_name, :email, :pw_hash, NOW(), NOW())"
		password = request.form['password']
		pw_hash = bcrypt.generate_password_hash(password)
		print pw_hash
		data = {
			'first_name' : request.form['first_name'],
			'last_name' : request.form['last_name'],
			'email' : request.form['email'],
			'pw_hash' : pw_hash
		}
		mysql.query_db(query, data)
		return redirect('/wall')
	elif errors > 0:
		return redirect('/register')

@app.route('/register')
def reroute():
	return render_template('index.html')

@app.route('/wall')
def wall():
	query = 'SELECT * FROM messages JOIN wall_users ON messages.wall_user_id = wall_users.id ORDER BY messages.created_at DESC'
	messageData = mysql.query_db(query)
	return render_template('wall.html', messages=messageData)

@app.route('/login', methods=['POST'])
def login():
	email = request.form['email']
	password = request.form['password']
	query = 'SELECT id, email, pw_hash FROM wall_users WHERE email = "{}"'.format(email)
	result = mysql.query_db(query)
	print result
	if len(result) < 1:
		flash("Email not found")
		return redirect('/')
	if bcrypt.check_password_hash(result[0]['pw_hash'], password):
		session['Id'] = result[0]['id']
		print session['Id']
		return redirect('/wall')
	else:
		flash('Incorrect Password')
		return redirect('/')
	return redirect('/')

@app.route("/post", methods=['POST'])
def post():
	query = 'INSERT INTO messages (content, created_at, updated_at, wall_user_id) VALUES (:content, NOW(), NOW(), :wall_user_id)'
	data = {
		'content': request.form['message'],
		'wall_user_id': session['Id']
	}
	mysql.query_db(query, data)
	return redirect('/wall')

app.run(debug=True)