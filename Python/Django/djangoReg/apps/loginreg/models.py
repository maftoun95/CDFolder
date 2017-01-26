from __future__ import unicode_literals
from django.db import models
import re, bcrypt


#.get to set "user data". beware, app will freakout
#you have to be careful with try/except, accidental exceptions may occur
#
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')

class UserManager(models.Manager):
	def loginVal(self, postData):
		response = []
		user = self.filter(email=postData['email']) #user is a list
		if user:
			if bcrypt.hashpw(postData['email'].encode(), user[0].password) == user[0].password:
				response.append(user[0])
				return response
			else:
				response.append("email or password are incorrect")
				return response

	def registerVal(self, postData):
		response = []
		if not EMAIL_REGEX.match(postData['email']):
			response.append('Email invalid; please submit a valid email.')
		user = self.filter(email=postData['email'])
		if user:
			response.append('The given email is already in use, please provide another')
		print "first name: ", postData['first_name']
		if len(postData['first_name']) < 2:
			response.append("First name is too short")
		if len(postData['last_name']) < 2:
			response.append("Last name is too short")
		################################go to flask log/reg to find more validation cases

		if response:
			return response
		hashish = bcrypt.hashpw(postData['password'].encode(), bcrypt.gensalt())
		return self.create(first_name=postData['first_name'], last_name=postData['last_name'], email=postData['email'], password=hashish)

# Create your models here.
class Users(models.Model):
	"""docstring for Users"""
	first_name = models.CharField(max_length=100)
	last_name = models.CharField(max_length=100)
	email = models.CharField(max_length=255)
	password = models.CharField(max_length=255)
	created_at = models.DateField(auto_now_add=True)
	updated_at = models.DateField(auto_now=True)

	objects = UserManager()