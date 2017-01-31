from django.conf.urls import url, include
from . import views

###############################REMEMBER only using GET and POST...... semi restful
urlpatterns = [
    url(r'^$', views.home),
    url(r'^products$', views.index),
    url(r'^products/new$', views.new),
    url(r'^products/(?P<id>\d+)$', views.show, name = 'show'),
    url(r'^products/(?P<id>\d+)/edit$', views.edit),
    url(r'^products/(?P<id>\d+)/delete$', views.destroy),
    url(r'^products/(?P<id>\d+)/update$', views.update),
    url(r'^create$', views.create),
]
