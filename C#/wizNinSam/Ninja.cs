namespace ConsoleApplication {
    class Ninja : Human {
        public Ninja(string name) : base(name) {
            dexterity = 175;
        }
        public void steal(object obj) {
            if (obj is Human){
                Human human = obj as Human;
                System.Console.WriteLine("Hey look, its the Goodyear blimb! Over there!");
                human.health -= 10;
                health += 10;
            }
        }
        public void get_away() {
            System.Console.WriteLine("For real this time tho, I'm like 90% sure thats Natalie Portman at your 5 o'clock");
            health -= 15;
        }
    }
}