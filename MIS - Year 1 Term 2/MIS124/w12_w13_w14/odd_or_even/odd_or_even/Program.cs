using System;

namespace odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number:");
            int number = Int32.Parse(Console.ReadLine());

            if (number %2 == 0)
            {
                Console.WriteLine("This is even number.");
            }
            else 
            {
                Console.WriteLine("This is odd number.");
            }
        }
    }
}
