using System;

namespace sum_of_even_numbers_between_1_and_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("The i value= " + i + " and the sum= " + sum);
                }
            }
            

        }
    }
}
