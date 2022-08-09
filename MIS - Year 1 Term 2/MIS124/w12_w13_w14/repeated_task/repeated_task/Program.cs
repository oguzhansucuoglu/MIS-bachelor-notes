using System;

namespace repeated_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type your name:");

            string name = Console.ReadLine();

            for (int i=10;    i>=100;    i--)
            {
                Console.WriteLine(name);
            }
            /*
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            */
        }
    }
}
