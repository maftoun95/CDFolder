from django.shortcuts import render, redirect

# Create your views here.
def index(request):
	print "starts just fine "*222
	return render(request, 'surveyForm/index.html')

def proccess(request):
	#migrate to get access to session
	request.session['name'] = request.POST['name']
	request.session['loc'] = request.POST['location']
	request.session['lang'] = request.POST['lang']
	request.session['comment'] = request.POST['comment']
	return redirect('/result')

def result(request):
	return render(request, 'surveyForm/result.html')