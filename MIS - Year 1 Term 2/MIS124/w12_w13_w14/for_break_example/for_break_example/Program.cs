using System;

namespace for_break_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;

                Console.WriteLine($"Current i value {i} and sum value is {sum}");
                if (sum >= 1000)
                    break;


            }
        }
    }
}
