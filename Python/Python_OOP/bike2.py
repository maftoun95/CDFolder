class Bike(object):
    def __init__(self, price, speed):
        print 'initializing'
        self.price = price
        self.speed = speed
        self.miles = 0
    def displayInfo(self):
        print self.price
        print self.speed
        print self.miles
    def ride(self):
        print 'riding'
        self.miles += 10
        return self
    def reverse(self):
        print 'reversing'
        self.miles -= 5
        return self

trek = Bike(450, '33mph')
specialized = Bike(500, '55mph')
bmx = Bike(350, '25mph')

trek.ride().ride().ride().reverse().displayInfo()

specialized.ride().ride().reverse().reverse().displayInfo()

bmx.reverse().reverse().reverse().displayInfo()
