using System.Runtime.CompilerServices;
using StoreNS;

namespace StoreNS{
    public class PS5:Platform{
        public PS5(List<Game>?Games = null, int selected = -1, int paid = 0) : base(Games, selected, paid)
        {
            this.Games = Games ?? new List<Game>();
            this.selected = selected;
            this.paid = paid;
        }
        public PS5(PS5 ps5)
        {
            Games = ps5.Games;
            selected = ps5.selected;
            paid = ps5.paid;
        }

        protected override void Introduction()
        {
            Console.WriteLine("Welcome to PS5 Game Store!");
        }
        
        protected override void Payment()
        {
            int ten;
            int five;
            int one;

            Console.WriteLine("Number of 10 dollar bills: ");
            ten = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of 5 dollar bills: ");
            five = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of 1 dollar bills: ");
            one = Convert.ToInt32(Console.ReadLine());

            paid = (10 * ten) + (5 * five) + one;

            Console.WriteLine("\n");
        }
    }
}