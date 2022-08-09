using System;

namespace calculate_class_score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type visa score:");
            int visa_score = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Please type final score:");
            int final_score = Int32.Parse(Console.ReadLine());

            double class_point = (visa_score + final_score) / 2;
            Console.WriteLine("Your class score is: " + class_point);

            Console.ReadLine(); // to terminate the program
        }
    }
}
