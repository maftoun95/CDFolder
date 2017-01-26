class User(models.Model):
      first_name = models.CharField(max_length=45)
      last_name = models.CharField(max_length=45)
      email = models.EmailField()
      password = models.CharField(max_length=45)
      created_at = models.DateTimeField(auto_now_add=True)
      updated_at = models.DateTimeField(auto_now=True)


  class Message(models.Model):
      message = models.TextField()
      user = models.ForeignKey(User)
      created_at = models.DateTimeField(auto_now_add=True)
      updated_at = models.DateTimeField(auto_now=True)

  class Comment(models.Model):
      comment = models.TextField()
      user = models.ForeignKey(User)
      message = models.ForeignKey(Message)
      created_at = models.DateTimeField(auto_now_add=True)
      updated_at = models.DateTimeField(auto_now=True)