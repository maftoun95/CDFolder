from django.shortcuts import render, redirect
from django.contrib import messages
from .models import Users
from django.core.urlresolvers import reverse
import bcrypt

# Create your views here.
def index(request):
	return render(request, 'loginreg/index.html')

def login(request):
	viewsResponse = Users.objects.loginVal(request.POST)

	if viewsResponse['isLoggedIn']:
		request.session['user_ID'] = viewsResponse['user'].id
		request.session['fname'] = viewsResponse['user'].first_name
		return redirect(reverse('books:index'))
	else:
		for error in viewsResponse['errors']:
			messages.error(request, error)
		return redirect(reverse('users:index'))

def register(request):
	if viewsResponse['isRegistered']:
		request.session['user_ID'] = viewsResponse['user'].id
		request.session['fname'] = viewsResponse['user'].first_name
		return redirect(reverse('books:index'))
	else:
		for error in viewsResponse['errors']:
			messages.error(request, error)
		return redirect(reverse('users:index'))

def success(request):
	if not 'user_ID' in request.session:
		messages.error(request, 'You don\'t have permission to access that page, please log in')
		return redirect('users:index')
	return render(request, 'books:index')

def logout(request):
	request.session.clear()
	return redirect('/')
