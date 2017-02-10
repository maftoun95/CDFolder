namespace ConsoleApplication {
    class Samurai : Human{
        static int squad = 0;
        public Samurai(string name) : base(name) {
            health = 200;
            squad++;
        }
        public void death_blow(object obj) {
            if (obj is Human){
                Human human = obj as Human;
                if (human.health < 50) {
                    human.health = 0;
                    System.Console.WriteLine("YOU DEAD PUNKKKKKKKK");
                }
            }
        }
        public void meditate() {
            System.Console.WriteLine("Aye hold up right quick brodinski, I gotta get my zen on.");
            health = 200;
        }
        public static int how_many() {
            System.Console.WriteLine($"You dont want to play games son. The crew is rollin {squad} deep!");
            return squad;
        }
    }
}