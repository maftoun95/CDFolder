using System;

namespace ConsoleApplication{
    class Wizard : Human {
        public Wizard(string name) : base(name) {
            health = 50;
            intelligence = 25;
        }
        public void heal() {
            System.Console.WriteLine("Hold up let me catch my breath");
            health += 25 * intelligence;
        }
        public void fireball(object obj) {
            if (obj is Human){
                //obj as Human
                Human human = obj as Human;
                Random rand = new Random();
                System.Console.WriteLine("HADOUUUUUUUKENNNNNN");
                human.health -= rand.Next(20,50);
            }
        }
    }
}