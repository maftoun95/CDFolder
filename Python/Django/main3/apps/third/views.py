from django.shortcuts import render
from .models import People
# Create your views here.
def index(request):
	People.objects.create(first_name="Jimbo", last_name="Thorton")
	people = People.objects.all()
	print people
	return render(request, "third/index.html")