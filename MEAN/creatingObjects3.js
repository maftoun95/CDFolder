function VehicleConstructor(name, wheels, pass){

    this.name = name;
    this.wheels = wheels;
    this.passengers = pass;

    this.makeNoise = function(){
        console.log("BeeBeeeeeep");
    }
}