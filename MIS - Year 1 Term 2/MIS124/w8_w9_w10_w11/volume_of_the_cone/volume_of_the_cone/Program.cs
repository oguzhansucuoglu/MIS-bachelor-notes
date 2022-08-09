using System;

namespace volume_of_the_cone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the volume of the cone.");

            Console.WriteLine("Please type the radius value of the Cone:");
            double radius = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please type the height value of the Cone:");
            double h = Double.Parse(Console.ReadLine());

            // Calculation the volume of the Cone
            double volume = (Math.PI * radius * radius * h) / 3;
            //double volume2 = (Math.PI * Math.Pow(radius, 2) * h) / 3;
            Console.WriteLine("The volume of the cone is " + volume);

            Console.ReadLine();
        }
    }
}
