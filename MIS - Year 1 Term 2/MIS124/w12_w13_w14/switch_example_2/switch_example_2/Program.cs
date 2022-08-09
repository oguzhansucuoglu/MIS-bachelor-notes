using System;

namespace switch_example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a day name:");
            string day = Console.ReadLine().ToLower();
            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine("{0} is a weekday.", day);
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("{0} is a weekend.", day);
                    break;
                default:
                    Console.WriteLine("Unknown day!");
                    break;
            }
        }
    }
}
