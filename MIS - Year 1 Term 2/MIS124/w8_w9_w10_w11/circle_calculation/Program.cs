using System;

namespace circle_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type radius of circle:");
            int radius = Int32.Parse(Console.ReadLine());


            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of the circle is " + circumference);


            double area = Math.PI * radius * radius;
            // Math.Pow(base, exponent)
            double area2 = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is " + area);
            Console.WriteLine("The area of the circle is " + area2);


            Console.ReadLine();
        }
    }
}
