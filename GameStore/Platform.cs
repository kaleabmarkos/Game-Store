using System;
using System.Collections.Generic;


namespace StoreNS{
    public abstract class Platform{
        protected List<Game> Games;
        protected int selected;
        protected int paid;
        public Platform(List<Game>? Games = null, int selected = -1, int paid = 0)
        {
            this.Games = Games ?? new List<Game>();
            this.selected = selected;
            this.paid = paid;
            
        }
        protected Platform(Platform platform)
        {
            Games = new List<Game>(platform.Games);
            selected = platform.selected;
            paid = platform.paid;

        }

        protected abstract void Introduction();
        protected void Selection()
        {
            Console.WriteLine("Available PS5 Games:");
            string? choice;
            for(int i =0; i<Games.Count; i++)
            {
                Console.WriteLine($"{i+1} : Name {Games[i].Name} : Price ${Games[i].Price} : Units {Games[i].Units}");
            }
            Console.WriteLine("Pick a number of the game");
            choice = Console.ReadLine();
            if (choice == "0")
            {
                selected = -1;
            }
            else
            {
                selected = Convert.ToInt32(choice)-1;
                if (Games[selected] == null)
                {
                    Console.Clear();
                    Console.WriteLine("This is an invalid option. Try again\n");
                    Selection();
                }
                else if(Games[selected].Units == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Currently out of Stock....Try Again Later");
                    Selection();
                }
            }

        }
        protected virtual void Payment(){
            int twenties;
            int tens;

            Console.WriteLine("Enter your payment here (accepts 10 and 20 dollar bills.)");
            Console.WriteLine("How many 20$ bills: \t");
            twenties = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many 10$ bills: \t");
            tens = Convert.ToInt32(Console.ReadLine());

            paid = (twenties * 20) + (tens * 10);

            Console.WriteLine("\n");

        }
        protected virtual void Change(){
            
            int tens;
            int ones;

            int totalChange = paid - Games[selected].Price;

            if(paid < Games[selected].Price)
            {
                tens = paid / 10;
                ones = paid % 10;
            }
            else
            {
                tens = totalChange/10;
                ones = totalChange%10;
            }
            Console.WriteLine();
            Console.WriteLine($"Change in $10 bills:\t{tens}");
            Console.WriteLine($"Change in $1 bills:\t{ones}");
        }
        protected void Deliver()
        {
            if(paid < Games[selected].Price)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {
                Games[selected].Units--;
                Console.WriteLine($"Cogratulations {Games[selected].Name} will be delivered");
            }

            Console.ReadKey();
        }

    }
}
