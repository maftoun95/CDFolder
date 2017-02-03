from __future__ import unicode_literals
from ..loginreg.models import Users
from django.db import models

class BookManager(models.Manager):

    def addBook(self):
        pass

class Books(models.Model):
    name = models.CharField(max_length=255)
    author = models.CharField(max_length=255)
    created_at = models.DateField(auto_now_add=True)

    objects = BookManager()

class ReviewManager(models.Manager):
    pass

class Reviews(models.Model):
    author = models.ForeignKey(Users)
    book = models.ForeignKey(Books)
    rating = models.IntegerField()
    content = models.TextField()
    created_at = models.DateField(auto_now_add=True)
