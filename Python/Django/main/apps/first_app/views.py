from django.shortcuts import render
#CONTROLLER
#these are the handler functions that my routes proccess
# Create your views here.
def index(request):
	response = "My name is Iningo Montoya"
	return render(request, "first_app/index.html")