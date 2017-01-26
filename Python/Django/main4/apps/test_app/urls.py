from django.conf.urls import url, include
from . import views

urlpatterns = [
    url(r'^$', views.index, name="index"),
    url(r'^blog$', views.blogs),
    url(r'^comment/(?P<id>\d+)$', views.comments),
]
