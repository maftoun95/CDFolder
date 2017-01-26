from django.shortcuts import render, redirect
from django.contrib import messages
from .models import Users

# Create your views here.
def index(request):
	return render(request, 'loginreg/index.html')

def login(request):
	if request.method == 'POST':
		user = Users.objects.loginVal(request.POST)
		if 'user' in user:
			return redirect('success')
		else:
			for bammer in response:
				messages.error(request, bammer)

def register(request):
	user = Users.objects.registerVal(request.POST)
	print "users query result.... was it an error or the result of adding our query??..   ", user
	if 'user' in user:
		return redirect('success')
	else:
		for bammer in response:
				messages.error(request, bammer)

def success(request):
	request.session['first']
	return render(request, 'loginreg/success.html', context)

def logout(request):
	request.session.clear()
	return redirect('/')