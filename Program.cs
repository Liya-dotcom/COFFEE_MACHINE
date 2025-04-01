using System;
using System.Collections.Generic;

namespace COFFEE_MACHINE
{
    internal class Program
    {
        // Define coffee sizes and their prices using a dictionary
        private static readonly Dictionary<int, (string Name, decimal Price)> CoffeeSizes = new Dictionary<int, (string, decimal)>
        {
            { 1, ("Small", 15.50m) },
            { 2, ("Medium", 22.50m) },
            { 3, ("Large", 35.50m) },
            { 4, ("Extra-large", 43.50m) }
        };

        static void Main(string[] args)
        {
            decimal totalAmount = 0;
            DisplayWelcomeMessage();

            bool orderingCoffee = true;
            while (orderingCoffee)
            {
                // Get coffee selection
                int selectedSize = GetCoffeeSize();
                if (selectedSize == 0) continue; // Invalid selection, try again

                // Get quantity
                int quantity = GetQuantity();
                if (quantity == 0) continue; // Invalid quantity, try again

                // Calculate cost for this order
                decimal coffeeCost = CalculateCost(selectedSize, quantity);
                totalAmount += coffeeCost;

                // Display the current order summary
                DisplayOrderSummary(selectedSize, quantity, coffeeCost, totalAmount);

                // Ask if user wants to continue ordering
                orderingCoffee = AskToContinue();
            }

            // Display final amount and thank you message
            DisplayFinalBill(totalAmount);
        }

        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("  WELCOME TO TJITTERS COFFEE SHOP  ");
            Console.WriteLine("===================================\n");
        }

        private static int GetCoffeeSize()
        {
            Console.WriteLine("PLEASE SELECT YOUR COFFEE SIZE:");
            foreach (var size in CoffeeSizes)
            {
                Console.WriteLine($"{size.Key} - {size.Value.Name} (R{size.Value.Price:F2})");
            }
            Console.Write("\nEnter your choice (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && CoffeeSizes.ContainsKey(choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("\nInvalid choice! Please select a number between 1-4.");
                return 0;
            }
        }

        private static int GetQuantity()
        {
            Console.Write("\nHow many coffees would you like to have? ");

            if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
            {
                return quantity;
            }
            else
            {
                Console.WriteLine("\nInvalid quantity! Please enter a positive number.");
                return 0;
            }
        }

        private static decimal CalculateCost(int sizeChoice, int quantity)
        {
            return CoffeeSizes[sizeChoice].Price * quantity;
        }

        private static void DisplayOrderSummary(int sizeChoice, int quantity, decimal coffeeCost, decimal totalAmount)
        {
            Console.WriteLine("\n--- ORDER SUMMARY ---");
            Console.WriteLine($"{quantity} x {CoffeeSizes[sizeChoice].Name} Coffee @ R{CoffeeSizes[sizeChoice].Price:F2} each");
            Console.WriteLine($"Cost for this selection: R{coffeeCost:F2}");
            Console.WriteLine($"Running total: R{totalAmount:F2}");
            Console.WriteLine("--------------------\n");
        }

        private static bool AskToContinue()
        {
            while (true)
            {
                Console.Write("Would you like to order another coffee? (yes/no): ");
                string response = Console.ReadLine()?.Trim().ToUpper() ?? "NO";

                if (response == "YES" || response == "Y")
                {
                    Console.WriteLine(); // Add a blank line for better readability
                    return true;
                }
                else if (response == "NO" || response == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine($"Invalid response '{response}'. Please enter 'yes' or 'no'.");
                }
            }
        }

        private static void DisplayFinalBill(decimal totalAmount)
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("       FINAL BILL        ");
            Console.WriteLine("=========================");
            Console.WriteLine($"Total amount: R{totalAmount:F2}");
            Console.WriteLine("=========================");
            Console.WriteLine("\nThank you for visiting Tjitters Coffee Shop!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}