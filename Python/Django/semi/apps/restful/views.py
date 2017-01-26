from django.shortcuts import render, redirect
from django.contrib import messages

def index(request):
	print "            so far so good"
	return render(request, 'restful/index.html')

def show(request):
	return render(request, 'restful/show.html')

def new(request):
	return render(request, 'restful/new.html')

def edit(request):
	return render(request, 'restful/edit.html')

def create(request):
	return redirect('/')

def update(request):
	return redirect('/')

def destroy(request):
	return redirect('/')