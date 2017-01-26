from django.db import models

# Create your models here.
class People(models.Model):
	"""docstring for people"""
	first_name = models.CharField(max_length=45)
	last_name = models.CharField(max_length=45)
	created_at = models.DateTimeField(auto_now_add=True)
	updated_at = models.DateTimeField(auto_now=True)