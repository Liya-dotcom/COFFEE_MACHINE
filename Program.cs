using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COFFEE_MACHINE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int TotalCoffeeCost = 0;
            Console.WriteLine(" \nWELCOME TO TJITTERS COFFEE SHOP!!!!!!! \n");
        Start:
            Console.Write("PLEASE SELECT YOUR COFFEE SIZE - (1 - Small (R15.50), 2 -  Medium (R22.50), 3 - Large (R35.50), 4  - Extra-large (R43.50): \n");
           int UserChoice = int.Parse(Console.ReadLine());
            //double price = 0;
            switch(UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 15;
                break;

                case 2:
                    TotalCoffeeCost += 22;
                    break ;

                case 3:
                    TotalCoffeeCost += 35;
                    break;

                case 4:
                    TotalCoffeeCost += 43;
                    break;

                default:
                    Console.WriteLine("Invalid Choice", UserChoice);
                break;
            }

            Console.WriteLine("How many coffee you would like to have?: ");
            int qauntity = int.Parse(Console.ReadLine());
            TotalCoffeeCost = TotalCoffeeCost * qauntity;
                       
            Console.WriteLine("Your Total bill amount = {0:F} ",TotalCoffeeCost);
            //GetResponse();
        Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            String UserDecision = Console.ReadLine();
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;

                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
                    goto Decide;
            }
            Console.ReadKey();
        }
        
    }
}
