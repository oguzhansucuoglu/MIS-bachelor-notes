using System;

namespace for_example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int x = 0; x <= 100; x++)
            {
                sum = sum + x;
                //sum+=x;
                //Console.WriteLine(sum);
            }
            Console.WriteLine($"Sum of 0-100 is {sum}.");
        }
    }
}
