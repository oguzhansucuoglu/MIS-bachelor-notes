using System;

namespace area_of_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a side of triangle:");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please type height of triangle:");
            double height = Double.Parse(Console.ReadLine());


            double area = a * height / 2;
  
            Console.WriteLine("Area of triangle = " + area);


            Console.ReadLine();
        }
    }
}
