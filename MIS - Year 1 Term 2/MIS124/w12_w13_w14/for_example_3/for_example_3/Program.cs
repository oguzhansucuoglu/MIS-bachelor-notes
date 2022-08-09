using System;

namespace for_example_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 0; i <= 100; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    //sum+=x;
                    Console.WriteLine($"Current i is {i} and sum is {sum}.");
                }
            }

        }
    }
}
