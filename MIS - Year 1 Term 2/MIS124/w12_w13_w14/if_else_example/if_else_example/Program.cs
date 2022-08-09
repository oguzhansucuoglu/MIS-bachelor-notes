using System;

namespace if_else_example
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * f(x) = x^2 - 2x
             * 
             * if f(x)<0; y = -1
             * else if f(x) = 0 ; y = 0
             * else if f(x)>0; y = 1
             * 
             * 
             */

			Console.WriteLine("Type x value:");
			double x = Double.Parse(Console.ReadLine());
			int y = 2;
			double fx = Math.Pow(x, 2) - 2 * x;

			if (fx < 0) 
                y = -1;
			else if (fx == 0) 
                y = 0;
			else if (fx > 0) 
                y = 1;
			Console.WriteLine("fx = {0}", fx);
			Console.WriteLine("y value: {0}", y);
			Console.ReadKey();

        }
    }
}
