from django.conf.urls import url
from . import views

urlpatterns = [
	url(r'^$', views.index),
	url(r'^proccess$', views.proccess),
	url(r'^result$', views.result)
]