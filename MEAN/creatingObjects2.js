class Vehicle {
    constructor(name, wheels, pass, speed){
        var distance_travelled = 0;
        var updateDistanceTravelled = function(){
            distance_travelled += speed;
        }


        this.name = name;
        this.wheels = wheels;
        this.passengers = pass;
        this.speed = speed;

        this.makeNoise = function(){
            console.log("BeeBeeeeeep");
        }
        this.move = function(){
            updateDistanceTravelled();
            this.makeNoise();
        }
        this.checkMiles = function(){
            console.log(distance_travelled);
        }
    }
}

var bike = new Vehicle("Trek", 2, 2, 25);
bike.makeNoise = function(){
    console.log('ring ring!')
}

var sedan = new Vehicle("Betty", 4, 5, 55);
sedan.makeNoise = function(){
    console.log('Honk Honk!')
}

var bus = new Vehicle("Biggie", 4, 29, 39);
bus.allAboard = function(num){
    bus.passengers += num;
}

bike.makeNoise();
sedan.makeNoise();
bus.makeNoise();

sedan.move();
sedan.checkMiles();