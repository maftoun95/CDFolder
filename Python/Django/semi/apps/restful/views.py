from django.shortcuts import render, redirect
from django.contrib import messages
from .models import Product

def index(request):
	allDem = Product.objects.list()
	context = {
		"products" : allDem
	}
	return render(request, 'restful/index.html', context)

def home(request):
	print "            redirecting to /products"

	return redirect('/products')

def show(request, id):
	prod = Product.objects.getProd(id)
	context = {
		'id' : id,
		'prod' : prod
	}
	return render(request, 'restful/show.html')

def new(request):
	return render(request, 'restful/new.html')

def edit(request, id):
	context = {
		'id' : id
	}
	return render(request, 'restful/edit.html')

def create(request):
	viewsResponse = Product.objects.createProd(request.POST)
	if viewsResponse['added']:
		request.session['name'] = viewsResponse['prod'].name
		return redirect('/')
	else:
		for error in viewsResponse['errors']:
			messages.error(request, error)
		return redirect('/')


def update(request):
	return redirect('/')

def destroy(request, id):
	context = {
		'id' : id
	}
	return redirect('/')