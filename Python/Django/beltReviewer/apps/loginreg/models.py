from __future__ import unicode_literals
from django.db import models



#.get to set "user data". beware, app will freakout
#you have to be careful with try/except, accidental exceptions may occur
#
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]+$')

class UserManager(models.Manager):

	def registerVal(self, postData):

		errors = []
		if len(postData['email']) < 1:
			errors.append('An email is required for registration')
		if not EMAIL_REGEX.match(postData['email']):
			errors.append('Email invalid; please submit a valid email.')
		used = self.filter(email=postData['email'])
		if used:
			errors.append('The given email is already in use, please provide another')
		if len(postData['first_name']) < 2:
			errors.append("First name is too short")
		if len(postData['last_name']) < 2:
			errors.append("Last name is too short")
		if len(postData['password']) < 8:
			errors.append('Password must be at least 8 characters long')
		if postData['password'] != postData['confirm']:
			errors.append('Passwords dont match, please confirm your password')
		#if errors exist, return all relevent error messages
		modelsResponse = {}

		if errors:
			modelsResponse['isRegistered'] = False
			modelsResponse['errors'] = errors
		else:
			modelsResponse['isRegistered'] = True
			hashish = bcrypt.hashpw(postData['password'].encode(), bcrypt.gensalt())
			newser = self.create(first_name=postData['first_name'], last_name=postData['last_name'], email=postData['email'], password=hashish)
			modelsResponse['user'] = newser
		return modelsResponse

	def loginVal(self, postData):
		user = self.filter(email=postData['email'])
		errors = []
		modelsResponse = {}
		if not user:
			errors.append('The provided email is not in our system.')
		else:
			if bcrypt.checkpw(postData['password'].encode(), user[0].password.encode()):
				modelsResponse['isLoggedIn'] = True
				modelsResponse['user'] = user[0]
			else:
				errors.append('email/password combination did not match...')
		if errors:
			modelsResponse['isLoggedIn'] = False
			modelsResponse['errors'] = errors
		return modelsResponse

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