import random
from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'bigSecret'

@app.route('/')
def greatNumber():
	if not 'randomNumber' in session:
		session['randomNumber'] = random.randrange(1, 101)

	return render_template('index.html')

@app.route('/guess', methods=['POST'])
def guess():
	session['guess'] = int(request.form['num'])
	if int(request.form['num']) == int(session['randomNumber']):
		session['gameGuess'] = 'THATS RIGHT! You guessed my number, '+ str(session['randomNumber'])

	elif int(request.form['num']) < int(session['randomNumber']):
		session['gameGuess'] = 'Nope, your guess of '+ request.form['num'] +' was too low...'
	elif int(request.form['num']) > int(session['randomNumber']):
		session['gameGuess'] = 'Nope, your guess of '+ request.form['num'] +' was too big...'
	print request.form['num'], session['randomNumber']
	print session
	return redirect('/')

@app.route('/clear')
def clear():
	session.clear()
	return redirect('/')

app.run(debug=True)