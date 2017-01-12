from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'bigSecret'

def seshWork():
	try:
		session['count'] += 1
	except KeyError:
		session['count'] = 1

@app.route('/')
def index():
	seshWork()
	print session.keys()
	return render_template("index.html")

@app.route('/double')
def double():
	seshWork()
	return redirect('/')

@app.route('/clear')
def clear():
	for key in session.keys():
  		session.pop(key)
	return redirect('/')

app.run(debug=True)