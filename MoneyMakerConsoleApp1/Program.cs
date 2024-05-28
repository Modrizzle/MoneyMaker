using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMakerConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             This program converts an amount in cents to the minimum number of coins.
             Author: Mohammed Kekli.
            */

            // Step 1: Welcome Message
            Console.WriteLine("Welcome to Money Maker!");

            // Step 2: Input
            Console.Write("Enter an amount in cents: ");
            string input = Console.ReadLine(); // Capture user input as a string
            double amount = Convert.ToDouble(input); // Convert the string input to a double

            // Round down the amount to the nearest whole number to handle decimal inputs
            amount = Math.Floor(amount);

            // Step 3: Define Coin Values for US Currency
            double quarterValue = 25; // A quarter is worth 25 cents
            double dimeValue = 10; // A dime is worth 10 cents
            double nickelValue = 5; // A nickel is worth 5 cents
            double pennyValue = 1; // A penny is worth 1 cent

            // Step 4: Calculate Maximum Quarters
            double quarters = Math.Floor(amount / quarterValue); // Calculate the number of quarters

            // Step 5: Calculate Remaining Amount after Quarters
            double remainder = amount % quarterValue; // Use modulo to find the remaining amount

            // Step 6: Calculate Maximum Dimes
            double dimes = Math.Floor(remainder / dimeValue); // Calculate the number of dimes

            // Step 7: Calculate Remaining Amount after Dimes
            remainder = remainder % dimeValue; // Use modulo to find the remaining amount

            // Step 8: Calculate Maximum Nickels
            double nickels = Math.Floor(remainder / nickelValue); // Calculate the number of nickels

            // Step 9: Calculate Remaining Amount after Nickels
            remainder = remainder % nickelValue; // Use modulo to find the remaining amount

            // The remaining amount is the number of pennies
            double pennies = remainder;

            // Step 10: Output
            Console.WriteLine($"{amount} cents is equal to:");
            Console.WriteLine($"Quarters: {quarters}");
            Console.WriteLine($"Dimes: {dimes}");
            Console.WriteLine($"Nickels: {nickels}");
            Console.WriteLine($"Pennies: {pennies}");
        }
    }
}
