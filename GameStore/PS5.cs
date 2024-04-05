using System.Runtime.CompilerServices;
using StoreNS;

namespace StoreNS{
    public class PS5:Platform{
        /*************************************************************************
         *  Method: PS5
         *  **********************************************************************
         *  Description: Constructor for the ps5 class. The constructor takes three
                         optional parameters: a list of games, the index of the 
                         selected app, and the amount paid.                     **
         *  **********************************************************************
         *  Input Arguments:   Game, price, units                               **
         *  Output Arguments:None                                               **
         *  Return: none                                                        **
         *  *********************************************************************/
        public PS5(List<Game>?Games = null, int selected = -1, int paid = 0) : base(Games, selected, paid)
        {
            this.Games = Games ?? new List<Game>();
            this.selected = selected;
            this.paid = paid;
        }
        /*************************************************************************
         *  Method: PS5
         *  **********************************************************************
         *  Description:Copy Constructor for the ps5 class that will create a new
                        object class with the properties initialized to the same
                        values as the provided object of the ps5 class          **
         *  **********************************************************************
         *  Input Arguments:   PS5 class                                        **
         *  Output Arguments: Game, price, units                                **
         *  Return: none                                                        **
         *  *********************************************************************/
        private PS5(PS5 ps5)
        {
            Games = ps5.Games;
            selected = ps5.selected;
            paid = ps5.paid;
        }
        /*************************************************************************
         *  Method: Introduction
         *  **********************************************************************
         *  Description:Welcomes user to store                                  **
         *  **********************************************************************
         *  Input Arguments:   none                                             **
         *  Output Arguments: none                                              **
         *  Return: none                                                        **
         *  *********************************************************************/
        protected override void Introduction()
        {
            Console.WriteLine("Welcome to PS5 Game Store!");
        }
        /*************************************************************************
         *  Method: Payment
         *  **********************************************************************
         *  Description:Sets up the payment method for the PS5 store because the PS5
                        payment method does not follow the platforms.           **
         *  **********************************************************************
         *  Input Arguments:   none                                             **
         *  Output Arguments: none                                              **
         *  Return: none                                                        **
         *  *********************************************************************/
        protected override void Payment()
        {
            int ten;
            int five;
            int one;
            try{
            Console.WriteLine($"Enter your payment here (accepts 10, 5 and 1 dollar bills). Total is ${Games[selected].Price}.");
            Console.WriteLine("Number of 10 dollar bills: ");
            ten = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of 5 dollar bills: ");
            five = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of 1 dollar bills: ");
            one = Convert.ToInt32(Console.ReadLine());

            paid = (10 * ten) + (5 * five) + one;

            Console.WriteLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Payment();
            }
            
        }
    }
}
