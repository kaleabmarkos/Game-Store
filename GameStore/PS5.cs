using System.Runtime.CompilerServices;
using StoreNS;

namespace StoreNS{
    public class PS5:Platform{
        public PS5()
        {
            Games.Add(new Game("Call of Duty", 54, 3));
            Games.Add(new Game("Elden Ring", 50, 4));
            Games.Add(new Game("Horizon", 46, 5));
            Games.Add(new Game("Unchgarted", 57, 2));
        }
        public PS5(PS5 ps5): base(ps5) {}

        public override void Introduction()
        {
            Console.WriteLine("Welcome to PS5 Game Store!");
        }
        public override int Selection()
        {
            Console.WriteLine("Available PS5 Games:");
            DisplayGames();
            int choice;
        do
        {
            Console.WriteLine("Enter the number of the game you want to buy:");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= Games.Count)
            {
                if (Games[choice - 1].Units > 0)
                {
                    Games[choice - 1].Units--;  // Decrement the units number
                    return Games[choice - 1].Price;
                }
                else
                {
                    Console.WriteLine("Selected game is out of stock. Please select another.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        } while (true);
        }
        private void DisplayGames()
        {
            for(int i =0; i<Games.Count; i++){
                Console.WriteLine($"{i+1}, {Games[i].Name} - ${Games[i].Price} - {Games[i].Units} in stock");
            }
        }
        public override void Payment(int totalAmount)
        {
            Console.WriteLine($"Please provide payment of $10, $5, $1. Total amount: ${totalAmount}");
            int[] paymentOptions = { 10, 5, 1};
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
                    Console.WriteLine("Invaliid input. Please enter a valid number(positive number)");
                }

                paymentCounts[Array.IndexOf(paymentOptions, option)] = count;
                totalAmount -= count * option;
            }

            if (totalAmount == 0)
            {
                Console.WriteLine("Payment Successful");
                return;
            }
            else if(totalAmount > 0)
            {
                Console.WriteLine($"Insuficent amount. Missing ${totalAmount}.");
                ProcessPayment(paymentOptions, totalAmount+SumOfPayments(paymentCounts, paymentOptions));
            }
            else
            {
                Change(Math.Abs(totalAmount));
            }
        }
        public override void Change(int changeAmount)
        {
            Console.WriteLine($"Your change is ${changeAmount} and would be");
            CalculateChange(changeAmount, new int[]{10, 1});
        }
        private void CalculateChange(int amount, int[] changeOptions)
        {
            foreach (var option in changeOptions)
            {
                int count = amount/option;
                amount%=option;
                Console.WriteLine($"({count})${option} bills");
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