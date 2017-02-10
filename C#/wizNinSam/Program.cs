namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human Tonto = new Human("dumdum",4,7,9,44);
            Wizard Longbeard = new Wizard("Moriarty");
            Ninja Slink = new Ninja("Ibuki");
            Samurai Musashi = new Samurai("Miyamoto");
            System.Console.WriteLine("Shennanigans commencing:");
            Slink.steal(Longbeard);
            Tonto.attack(Musashi);
            Musashi.death_blow(Tonto);
            Slink.get_away();
            Samurai Hanzo = new Samurai("Gonzo");
            Samurai Peter = new Samurai("Pan");
            Samurai Alec = new Samurai("Baldwin");
            Samurai Scar = new Samurai("Face");
            Samurai Die = new Samurai("Antwoord");
            Samurai Kentaro = new Samurai("The Drunk");

            Samurai.how_many();
        }
    }
}
