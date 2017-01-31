from __future__ import unicode_literals
import re, bcrypt
from django.db import models

class ProductManager(models.Manager):

	def createProd(self, postData):
		PRICE_REGEX = re.compile(r'^[0-9\.]+$')
		errors = []
		if not PRICE_REGEX.match(postData['price']):
			errors.append('numbers only for price please!!')
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
		list = self.all()
		return list

	def getProd(self, id):
	 	item = self.filter(id=id).first()
	 	return item

	def destroy(self, id):
		self.filter(id=id).delete()

	def update(self, id, postData):
		item = self.get(id=id)
		item.name = postData['name']
		item.description = postData['description']
		item.price = postData['price']
		item.save()

# Create your models here.
class Product(models.Model):
	name = models.CharField(max_length=100)
	description = models.CharField(max_length=100)
	price = models.CharField(max_length=255)
	created_at = models.DateField(auto_now_add=True)
	updated_at = models.DateField(auto_now=True)

	objects = ProductManager()
