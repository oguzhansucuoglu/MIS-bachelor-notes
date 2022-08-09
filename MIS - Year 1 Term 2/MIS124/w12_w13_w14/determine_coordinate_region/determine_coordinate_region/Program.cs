using System;

namespace determine_coordinate_region
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type x value:");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Type y value:");
            int y = Int32.Parse(Console.ReadLine());

            string desc="";

            if (x > 0 && y > 0)
                desc = "You are on the first region.";
            else if (x < 0 && y > 0)
                desc = "You are on the second region.";
            else if (x < 0 && y < 0)
                desc = "You are on the third region.";
            else if (x > 0 && y < 0)
                desc = "You are on the fourth region.";

            Console.WriteLine(desc);
        }
    }
}
