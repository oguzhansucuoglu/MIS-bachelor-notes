using System;

namespace printing_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Type your age:");
            int age = Int32.Parse(Console.ReadLine());

            // printing two variables at once
            // we use + operator to concatanate string and variabless
            Console.WriteLine("Your name: " + name + " and your age " + age);

            // another method to printout something using placeholder
            Console.WriteLine("Your name: {0} and your age {1}", name, age);

            // this is the last method to printout using $ sign and variable placeholder
            Console.WriteLine($"Your name: {name} and your age {age}", name, age);

        }  
    }
}
