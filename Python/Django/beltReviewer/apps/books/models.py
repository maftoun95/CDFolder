from __future__ import unicode_literals

from django.db import models

class BookManager(models.Manager):

    def addBook(self):
        pass

class Books(models.Model):
    name = models.CharField(max_length=255)
    review = models.TextField()
    rating = models.IntegerField()
    created_at = models.DateField(auto_now_add=True)
    updated_at = models.DateField(auto_now=True)

    objects = BookManager()
