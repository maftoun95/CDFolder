from django.shortcuts import render, redirect

# Create your views here.
def index(request):

	return render(request,'disapear/index.html')

def dojo(request, color):
	if color == 'blue':
		dude = "leo.png"
		name = "Leonardo"
	elif color == 'orange':
		dude = "mikey.png"
		name = "Michelangelo"
	elif color == 'red':
		dude = "raphael.png"
		name = "Raphael"
	elif color == 'purple':
		dude = "donny.png"
		name = "Donatello"
	else:
		dude = "fox.png"
		name = "Megan"
	context = {
		"src" : dude,
		"name" : name
	}
	return render(request, "disapear/dojo.html", context)

def crew(request):
	context = {
		"src" : "crew.png",
		"name" : "THE WHOLE CREW!"
	}
	return render(request, "disapear/dojo.html", context)