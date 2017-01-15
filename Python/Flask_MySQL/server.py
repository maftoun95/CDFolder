import random
from flask import Flask, render_template, request, redirect, session
# import the Connector function
from mysqlconnection import MySQLConnector
app = Flask(__name__)
# connect and store the connection in "mysql" note that you pass the database name to the function
mysql = MySQLConnector(app, 'world')
# an example of running a query
#print mysql.query_db("SELECT * FROM countries")

@app.route('/')
def index():
	return render_template('index.html')
@app.route('/add', methods=["POST"])
def add():
	query = "INSERT INTO countries (name, code, population) VALUES (:name, :code, :population)"
	data = {
		'name' : request.form['name'],
		'code' : request.form['code'],
		'population' : request.form['population']
	}
	mysql.query_db(query, data)
	return redirect('/')

app.run(debug=True)