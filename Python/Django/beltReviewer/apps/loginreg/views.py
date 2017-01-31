from django.shortcuts import render, redirect
from django.contrib import messages
from .models import Users

# Create your views here.
def index(request):
	return render(request, 'loginreg/index.html')

def login(request):
	print "-------------------", request.POST
	viewsResponse = Users.objects.loginVal(request.POST)

	if viewsResponse['isLoggedIn']:
		request.session['user_ID'] = viewsResponse['user'].id
		request.session['fname'] = viewsResponse['user'].first_name
		return redirect('users:success')
	else:
		for error in viewsResponse['errors']:
			messages.error(request, error)
		return redirect('users:index')

def register(request):
	print "-------------------", request.POST
	viewsResponse = Users.objects.registerVal(request.POST)
	print "The response from manager.regVal.     ", viewsResponse
	if viewsResponse['isRegistered']:
		request.session['user_ID'] = viewsResponse['user'].id
		request.session['fname'] = viewsResponse['user'].first_name
		return redirect('users:success')
	else:
		for error in viewsResponse['errors']:
			messages.error(request, error)
		return redirect('/')

def success(request):
	if not 'user_ID' in request.session:
		messages.error(request, 'You don\'t have permission to access that page, please log in')
		return redirect('users:index')
	return render(request, 'loginreg/success.html')

def logout(request):
	request.session.clear()
	return redirect('/')