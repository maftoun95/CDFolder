from django.shortcuts import render, redirect
import random, string

# Create your views here.
def index(request):
	# if not "word" in request.session:
	# 	request.session['word'] = "Some Thing"
	return render(request, 'generate/index.html')

def generator(request):
	result = ''
	count = 1
	if not 'att' in request.session:
		request.session['att'] = 1
	else:
		request.session['att'] += 1



	# if request.method == "POST":
	for i in range(9):
		result += random.choice(string.letters)
		print result
	request.session['word'] = result
	return redirect("/generator")
	# else:
	# 	print "CHANGE TO POST!!!"*66
	# 	return redirect("/generator")

def clear(request):
	request.session.flush()
	return redirect('/')