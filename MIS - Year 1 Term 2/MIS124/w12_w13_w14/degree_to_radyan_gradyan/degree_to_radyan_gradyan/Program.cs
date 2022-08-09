using System;

namespace degree_to_radyan_gradyan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a degree between 0 and 360.");

            double degree = Double.Parse(Console.ReadLine());

            double radyan = degree * Math.PI / 180;
            double gradyan = degree * 200 / 180;
        

            Console.WriteLine("Radyan = " + radyan);
            Console.WriteLine("Gradyan = " + gradyan);

            Console.ReadLine();
        }
    }
}
