function VehicleConstructor(name, wheels, pass, speed){
    var distance_travelled = 0;
    var updateDistanceTravelled = function(){
        distance_travelled += speed;
    }
    var vinFood = "123456789QWERTYUIOPASDFGHJKLZXCVBNM"

    this.name = name;
    this.wheels = wheels;
    this.passengers = pass;
    this.speed = speed;
    

    this.getDist = function(){
        console.log(distance_travelled);
    };

    this.setDist = function(){
        updateDistanceTravelled();
    }

    this.setVin = function(){
        var vin = "";
        for (var i = 0; i < 17; i++){
            vin += vinFood[Math.floor(Math.random()*35)]
        }
        return vin;
    }
    this.vin = this.setVin();
}

VehicleConstructor.prototype.makeNoise = function(){
    console.log("BeeBeeeeeep");
}

VehicleConstructor.prototype.move = function(){
    this.setDist();
    this.makeNoise();
}

VehicleConstructor.prototype.checkMiles = function(){
    this.getDist()
}

var bike = new VehicleConstructor("Chopper", 2, 2, 55);
var sedan = new VehicleConstructor("M3", 4, 5, 99);
var bus = new VehicleConstructor("Metro", 6, 39, 55);

bike.makeNoise = function(){
    console.log('ring ring!')
}
sedan.makeNoise = function(){
    console.log('Honk Honk!')
}
bus.pickUpPassengers = function(num){
    bus.passengers += num;
}

bike.makeNoise();
sedan.makeNoise();
bus.pickUpPassengers(6);

var vw = new VehicleConstructor("Slug Bug", 5, 13, 55);

vw.makeNoise();
vw.move();
console.log('lets check miles')
vw.checkMiles();

console.log(`Check out my vin! Its ${vw.vin}`);