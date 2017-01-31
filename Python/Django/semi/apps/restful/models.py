from __future__ import unicode_literals
import re, bcrypt
from django.db import models

class ProductManager(models.Manager):

	def createProd(self, postData):
		PRICE_REGEX = re.compile(r'^[0-9\.]+$')
		errors = []
		if not PRICE_REGEX.match(postData['price']):
			errors.append('numbers only for price please!!')
		here = self.filter(name=postData['name'])
		if here:
			errors.append('That product is already listed. Anything else you\'d like to add??')
		modelsResponse = {}

		if errors:
			modelsResponse['added'] = False
			modelsResponse['errors'] = errors
		else:
			modelsResponse['added'] = True
			newProd = self.create(name=postData['name'], description=postData['description'], price=postData['price'])
			modelsResponse['prod'] = newProd
		return modelsResponse
	def list(self):
		print "the selffffffffffffffffffffffffffff ",self
		list = self.all()
		return list
	 def getProd(self, id):
	 	item = self.filter(id=id)
	 	return item

# Create your models here.
class Product(models.Model):
	"""docstring for Users"""
	name = models.CharField(max_length=100)
	description = models.CharField(max_length=100)
	price = models.CharField(max_length=255)
	created_at = models.DateField(auto_now_add=True)
	updated_at = models.DateField(auto_now=True)

	objects = ProductManager()