from django.conf.urls import url, include
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^ninjas/(?P<color>\w+)$', views.dojo),
    url(r'^ninjas$', views.crew),
]
