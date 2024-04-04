using StoreNS;
class Program
{
    static void Main(string[] args)
    {
      List<Game> PS5 = new List<Game>
        {
            new Game("Call of Duty", 54, 3),
            new Game("Elden Ring", 50, 4),
            new Game("Horizon", 46, 5),
            new Game("Uncharted",57, 2)
        };
        List<Game> Switch = new List<Game>
        {
            new Game("Animal Crossing", 46, 3),
            new Game("Link's Awakening", 50, 5),
            new Game("Pokemon Legends", 57, 1)
        };

        PS5 ps5 = new PS5(PS5);
        Switch switchobj = new Switch(Switch);

        string ? key = "0";

        do
        {
            Console.Clear();
            Console.WriteLine("Hello, would you like to shop PS5 games or Switch games");
            Console.WriteLine("1: PS5");
            Console.WriteLine("2: Switch");
            Console.WriteLine("3: Exit");

            key = Console.ReadLine();
            if (key == "1")
            {
                {ps5.Start();}
            }
            else if(key == "2")
            {
                {switchobj.Start();}
            }
        }while(key != "3");

        Console.WriteLine("Have a nice day");
    }
}
