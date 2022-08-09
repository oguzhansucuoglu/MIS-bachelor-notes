using System;

namespace calculate_feet_to_cm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type feet size:");

            double feet = Double.Parse(Console.ReadLine());

            double cm = feet * 30;

            Console.WriteLine("Cm equavelent: {0}", cm);
        }
    }
}
