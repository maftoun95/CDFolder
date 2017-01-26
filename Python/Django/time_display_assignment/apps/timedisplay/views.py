from django.shortcuts import render, redirect
import datetime
#CONTROLLER
#these are the handler functions that my routes proccess
# Create your views here.
def index(request):
	dict = {
		"time": datetime.datetime.now()
	}
	print "WORKinG"*10
	return render(request,'timedisplay/index.html', dict)


def create(request):
	if request.method == "POST":
		print "*"*50
		print request.POST
		print request.method
		print "* "*50
		request.session['name'] = request.POST['first_name']
		print "0"*92
		print "SESSION name:       ", request.session['name']
		return redirect("/")
	else:
		print request.method
		return redirect("/")