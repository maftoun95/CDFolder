namespace ConsoleApplication{
    public class Human
{
    public string name;

    public int health { get; set; }

    //properties are set to private by default. These props dont need to be messed with.
    int strength { get; set; }
    int intelligence { get; set; }
    int dexterity { get; set; }
    // make your dudebro, pass a string which gets set to name.
    public Human(string person){
        name = person;
        // these are all static props
        strength = 3;
        intelligence = 3;
        dexterity = 3;
        health = 100;
    }
    // OVERLOAD TIME! if we pass a bunch of stuffola instead of just the string for name, the 
    // stuffola is used to set various properties
    public Human(string person, int str, int intel, int dex, int hp){
        // stuff is the stuff we passed
        name = person;
        strength = str;
        intelligence = intel;
        dexterity = dex;
        health = hp;
    }
    // pew pew hit you. we accept the enemy to be attacked as a parameter
    // they're just a vanilla object. lame. Why?? is there an instance where we 
    // wouldnt want to receive a Human? are we attacking livestock?
    public void attack(object obj){
        set the 
        Human enemy = obj as Human;
        if(enemy == null){
            // no enemy? no dice
            Console.WriteLine("Failed Attack");
        } else {
            enemy.health -= strength * 5;
        }
    }
}
}