from django.conf.urls import url, include
from . import views

urlpatterns = [
	url(r'^generator$', views.index),
	url(r'^clear$', views.clear),
	url(r'^$', views.generator),
	#url(r)
]