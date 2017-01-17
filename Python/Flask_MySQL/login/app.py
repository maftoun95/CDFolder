import re
from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import MySQLConnector
from flask.ext.bcrypt import Bcrypt
app = Flask(__name__)
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')
bcrypt = Bcrypt(app)
mysql = MySQLConnector(app, 'mydb')
#print mysql.query_db("SELECT * FROM logins")
app.secret_key = "busysignal"

@app.route('/')
def index():
	return render_template('index.html')

@app.route('/register')
def register():
	return render_template('register.html')

@app.route('/login', methods=['POST'])
def login():
	query = 'SELECT id, password FROM logins WHERE email = "{}"'.format(request.form['email'])
	user = mysql.query_db(query)
	print user
	if len(user)<1:
		errors +=1
		flash('email doesnt exist')

	elif not bcrypt.check_password_hash(user[0]['password', request.form['email']]):
		errors += 1
		flash('go away, liar')
	return redirect('/')

@app.route('/signup', methods=['POST'])
def signup():
	errors = 0

	if len(request.form['first']) < 2:
		errors += 1
		flash('needs more characters in first name')
	elif not NAME_REGEX.match(request.form['first']):
		errors += 1
		flash('no numbers allowed in first name')
	if len(request.form['last']) < 2:
		errors += 1
		flash('needs more characters in last name')
	elif not NAME_REGEX.match(request.form['last']):
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
		query = "INSERT INTO logins (first_name, last_name, email, pw_hash, created_at, updated_at) VALUES (:first_name, :last_name, :email, :pw_hash, NOW(), NOW())"
		password = request.form['password']
		pw_hash = bcrypt.generate_password_hash(password)
		print pw_hash
		data = {
			'first_name' : request.form['first'],
			'last_name' : request.form['last'],
			'email' : request.form['email'],
			'pw_hash' : pw_hash
		}
		mysql.query_db(query, data)
		return redirect('/')
	elif errors > 0:
		return redirect('/register')

app.run(debug=True)