using System;

namespace console_read
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Console.Read();
            Console.WriteLine("You typed: " + number); // It prints integer value as ASCII

            string character = Console.Read(); // It throws an error
            Console.WriteLine("You typed: " + character); 
        }
    }
}
