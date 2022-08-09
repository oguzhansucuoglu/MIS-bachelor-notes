using System;

namespace part_of_area_a_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an angle of circle");
            double alfa = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please type raius of circle:");
            double r = Double.Parse(Console.ReadLine());


            double area = alfa / 360 * Math.PI * r * r;
            double area2 = alfa / 360 * Math.PI * Math.Pow(r, 2);
            
            Console.WriteLine("Area = " + area2);
        }
    }
}
