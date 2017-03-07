var personConstructor = function(fname){
    var obj = {
        name: fname,
        distance_traveled : 0,
        say_name : function(){
            console.log(this.name);
        },
        say_something : function(say){
            console.log(`${this.name} says ${say}.`)
        },
        walk: function(){
        console.log(`${this.name} is walking`);
        distance_traveled += 3;
        return distance_traveled;
        },
        run: function(){
            console.log(`${this.name} is runing`);
            distance_traveled += 10
            return distance_traveled;;
        },
        crawl: function(){
            console.log(`${this.name} is crawling`);
            distance_traveled += 1;
            return distance_traveled;
        }
    }
    return obj;
}

var ninjaConstructor = function(nm, coh){
    var belts = ["Yellow Belt", "Red Belt", "Black Belt"];
    var level = 0;
    var obj = {
        name : nm,
        cohort : coh,
        belt_level : belts[level],
        levelUp : function(){
            if(level < 3){
                level++;
                this.belt_level = belts[level];
            } else { console.log("if stmt failed")}
        }
    }
    return obj;
}

var hanzo = ninjaConstructor("Hanzo","January");
console.log(hanzo.belt_level)
hanzo.levelUp();
hanzo.levelUp();
console.log(hanzo.belt_level)
