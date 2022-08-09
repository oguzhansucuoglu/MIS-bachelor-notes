using System;

namespace switch_example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number:");
            int number = Int32.Parse(Console.ReadLine());
            int number_status = Math.Abs(number % 2);
            switch (number_status)
            {
                case 0:
                    Console.WriteLine("{0} is even number.", number);
                    break;
                case 1:
                    Console.WriteLine("{0} is odd number.", number);
                    break;
                default:
                    Console.WriteLine("Unknown number.");
                    break;
            }
        }
    }
}
