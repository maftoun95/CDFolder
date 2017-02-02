from django.shortcuts import render, redirect

# Create your views here.
def index(request):
    return render(request, "books/index.html")

def logout(request):
	request.session.clear()
	return redirect(reverse('users:index'))
