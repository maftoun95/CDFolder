"""
Well hello there intrepid coder. I will be your guide through this
login and registration app. Feel free to include this app folder in
your next project to speed up development. I would highly suggest that
if you end up recycling this code that you follow through this comment
filled journey and re write the comments as you go. This way you will
understand what is going on and what you can expect. I also encourage
to improve uppon this as you see fit. Lets go.

So this is the first stop after the home route is hit. The first thing
that happens is Django will look in here, the project level urls page,
for a route
"""
from django.conf.urls import url, include


urlpatterns = [
    url(r'^', include('apps.loginreg.urls', namespace='users')),
]