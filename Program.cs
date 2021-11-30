using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");

            string totalAsString = Console.ReadLine();
            double myAgeAsDouble = Convert.ToDouble(totalAsString);
            Console.WriteLine($"An example: {myAgeAsDouble}");

        }
    }
}
