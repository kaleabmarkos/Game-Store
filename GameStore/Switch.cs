using System.Runtime.CompilerServices;
using StoreNS;

namespace StoreNS{
    public class Switch:Platform{
        public Switch()
        {
            Games.Add(new Game("Animal Crossing", 46, 3));
            Games.Add(new Game("Link's Awakening", 50, 5));
            Games.Add(new Game("Pokemon Legends", 57, 1));
        }
        public Switch(Switch switchobj) : base(switchobj) { }

        public override void Introduction()
        {
            Console.WriteLine("Welcome to Swich Game Store!");
        }
        public override int Selection()
        {
            Console.WriteLine("Available Swich Games:");
            DisplayGames();
            return GetSelection();
        }
        private int GetSelection()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter the number of the game you want to buy:");
                if(int.TryParse(Console.ReadLine(), out choice) && choice> 0 && choice <= Games.Count)
                {
                    if(Games[choice - 1].Units > 0){
                        Games[choice - 1].Units--;
                        return Games[choice - 1].Price;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }while(true);
        }
        private void DisplayGames()
        {
            for(int i=0; i<Games.Count; i++){
                Console.WriteLine($"{i+1}, {Games[i].Name} - ${Games[i].Price} - {Games[i].Units} in stock");
            }
        }
        public override void Payment(int totalAmount)
        {
            Console.WriteLine($"Please provide payment of $20, $10. Total amount: ${totalAmount}");
            int[] paymentOptions = { 20, 10};
            ProcessPayment(paymentOptions, totalAmount);
        }
        private void ProcessPayment(int[] paymentOptions, int totalAmount)
        {
            int[] paymentCounts = new int[paymentOptions.Length];

            foreach(var option in paymentOptions){
                Console.WriteLine($"Enter the number of ${option} bills/coins:");

                int count;

                while (!int.TryParse(Console.ReadLine(), out count) || count <0)
                {
                    Console.WriteLine("Invaliid input. Please enter a non-negative");
                }

                paymentCounts[Array.IndexOf(paymentOptions, option)] = count;
                totalAmount -= count * option;
            }

            if (totalAmount == 0)
            {
                Console.WriteLine("Payment Successful");
                return;
            }
            else
            {
                Console.WriteLine($"Insuficent amount. Missing ${totalAmount}.");
                ProcessPayment(paymentOptions, totalAmount+SumOfPayments(paymentCounts, paymentOptions));
            }
        }
        public override void Change(int changeAmount)
        {
            Console.WriteLine($"Your change of ${changeAmount} is:");
            CalculateChange(changeAmount, new int[]{5, 2, 1});
        }
        private void CalculateChange(int amount, int[] changeOptions)
        {
            foreach (var option in changeOptions)
            {
                int count = amount/option;
                amount%=option;
                Console.WriteLine($"${option} bills/coins: {count}");
            }
        }
        private int SumOfPayments(int [] counts, int [] options)
        {
            int sum = 0;
            for(int i = 0; i<counts.Length; i++)
            {
                sum += counts[i] * options[i];
            }
            return sum;
        }

    }
}