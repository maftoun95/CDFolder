class Car(object):
    def display_all(self):
        print 'Price:', self.price
        print 'Speed:', self.speed
        print 'Fuel:', self.fuel
        print 'Mileage:', self.mileage
        print 'Tax:', self.tax
        print '-'*25
    def __init__(self, price, speed, fuel, mileage):
        self.price = price
        self.speed = speed
        self.fuel = fuel
        self.mileage = mileage
        if self.price > 10000:
            self.tax = 0.15
        else:
            self.tax = 0.12
        self.display_all()
    

ford = Car(3500, '50mph', 'full', '15mpg')
nissan = Car(7000, '75mph', 'empty', '20mpg')
vw = Car(10500, '80mph', 'half full', '25mpg')
peugeot = Car(2500, '30mph', 'enough', '20mpg')
mazda = Car(4500, '45mph', 'nearly empty', '15mpg')
chevy = Car(3900, '44mph', 'full', '19mpg')
