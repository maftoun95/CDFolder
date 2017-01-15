import random, re
from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import MySQLConnector
app = Flask(__name__)
# connect and store the connection in "mysql" note that you pass the database name to the function
mysql = MySQLConnector(app, 'mydb')
# an example of running a query
print mysql.query_db("SELECT * FROM emails")
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
app.secret_key = "zimbabwe"
@app.route('/')
def index():
	query = "SELECT * FROM emails"
	addresses = mysql.query_db(query)
	return render_template('index.html', emails=addresses)
@app.route('/emval', methods=["POST"])
def add():
	if not EMAIL_REGEX.match(request.form['email']):
		errmsg = "EMAIL IS NOT VALID"
		flash(errmsg)
		return redirect('/')
	elif EMAIL_REGEX.match(request.form['email']):
		query = "INSERT INTO emails (email, created_at) VALUES (:email, NOW())"
		data = {
			'email' : request.form['email']
		}
		flash(data['email'] + " is a valid email address, thank you.")
		mysql.query_db(query, data)
		return redirect('/')

app.run(debug=True)