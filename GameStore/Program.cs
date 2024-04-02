using StoreNS;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Select a console game system");
            Console.WriteLine("1. PS5");
            Console.WriteLine("2. Switch");
            Console.WriteLine("3. Exit");
            int choice;
            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1|| choice > 3)
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            if (choice == 3)
            {
                break;
            }

            Platform? platform=null;
            switch (choice)
            {
                case 1:
                    platform = new PS5();
                    break;
                case 2:
                    platform = new Switch();
                    break;

            }
            if(platform != null){
            platform.Introduction();
            int price = platform.Selection();
            platform.Payment(price);
            platform.Deliver();
            Console.WriteLine("Thank you for using the console gamestore.");
            }
            else{
                Console.WriteLine("Invalid choice. Exiting...");
            }
        }
    }
}