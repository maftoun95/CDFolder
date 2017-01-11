from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def hello_world():
    #return 'WAKEUUUUUUUUUUUUUUUPP'
    return render_template("index.html", name="Victor Von Doom")
app.run(debug=True)
