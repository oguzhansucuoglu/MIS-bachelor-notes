using System;

namespace if_clause_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a number:");
            int number = Int32.Parse( Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if (number == 0)
                Console.WriteLine("The number is zero");

        }
    }
}
