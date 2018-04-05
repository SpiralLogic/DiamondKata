using System;

namespace DiamondKata
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter desired diamond diameter: ");

            int diameter;
            while (!int.TryParse(Console.ReadLine(), out diameter))
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine(Diamond.Create(diameter) ?? "Enter a positive odd for the diameter");
        }
    }
}