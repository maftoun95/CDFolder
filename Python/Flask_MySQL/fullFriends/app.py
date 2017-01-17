import re
from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import MySQLConnector
app = Flask(__name__)
mysql = MySQLConnector(app, 'mydb')
#print mysql.query_db("SELECT * FROM friends")
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')
app.secret_key = "zimbabwe"

@app.route('/')
def index():
	query = "SELECT * FROM friends"
	friends = mysql.query_db(query)
	#print friends
	return render_template('index.html', friends=friends)

@app.route('/friends', methods=["POST"])
def create():
	if not EMAIL_REGEX.match(request.form['email']) or not NAME_REGEX.match(request.form['first']) or not NAME_REGEX.match(request.form['last']):
		errmsg = "Please make sure to provide a valid email and to propperly capitalize both names"
		flash(errmsg)
		return redirect('/')
	else:
		query = "INSERT INTO friends (first_name, last_name, email, time_stamp) VALUES (:first_name, :last_name, :email, NOW())"
		data = {
			'first_name' : request.form['first'],
			'last_name' : request.form['last'],
			'email' : request.form['email']
		}
		# print query
		# print data
		mysql.query_db(query, data)
		return redirect('/')

@app.route('/friends/<id>/edit')
def edit(id):
	query = "SELECT * FROM friends WHERE id=" + id
	friend = mysql.query_db(query)
	print friend
	return render_template('friends.html', friend=friend,id=id)

@app.route('/friends/<id>', methods=["POST"])
def update(id):
	replace = request.form['modifier']
	print replace
	replaceWith = request.form['value']
	query = "UPDATE friends SET " + replace + "='" + replaceWith + "' WHERE ID=" + id
	print query
	mysql.query_db(query)
	return redirect('/')

@app.route('/friends/<id>/delete', methods=["POST"])
def destroy(id):
	query = "DELETE FROM friends WHERE id = :id"
	data = {'id': id}
	print query
	print data
	mysql.query_db(query, data)
	return redirect('/')


app.run(debug=True)