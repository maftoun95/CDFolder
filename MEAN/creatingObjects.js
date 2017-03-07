function VehicleConstructor(name, wheels, pass){

    this.name = name;
    this.wheels = wheels;
    this.passengers = pass;

    this.makeNoise = function(){
        console.log("BeeBeeeeeep");
    }
}

var bike = new VehicleConstructor("Trek", 2, 2);
bike.makeNoise = function(){
    console.log('ring ring!')
}

var sedan = new VehicleConstructor("Betty", 4, 5);
sedan.makeNoise = function(){
    console.log('Honk Honk!')
}

var bus = new VehicleConstructor("Biggie", 4, 29);
bus.allAboard = function(num){
    bus.passengers += num;
}

bike.makeNoise();
sedan.makeNoise();
bus.makeNoise();