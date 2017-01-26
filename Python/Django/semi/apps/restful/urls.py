from django.conf.urls import url, include
from . import views

###############################REMEMBER only using GET and POST...... semi restful
urlpatterns = [
    url(r'^$', views.index),
    url(r'^products$', views.index),
    url(r'^products/new$', views.new),
    url(r'^products/show$', views.show), #change to products/<id>
    url(r'^products/edit$', views.edit), #change to products/<id>/edit
    url(r'^products/delete$', views.destroy), #change to products/<id>/delete
]