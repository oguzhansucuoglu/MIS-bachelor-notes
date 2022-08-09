using System;

namespace week_days
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a day name!");
            string day_name = Console.ReadLine().ToLower();

            if (day_name == "monday" || day_name == "thuesday" || day_name == "wednesday" || day_name == "thursday" || day_name == "friday")
            {
                Console.WriteLine(day_name + " is a week day.");
            } else if (day_name == "saturday" || day_name == "sunday")
            {
                Console.WriteLine(day_name + " is a weekend day.");
            } else
            {
                Console.WriteLine("Please type a validate day name!");
            }
        }
    }
}
