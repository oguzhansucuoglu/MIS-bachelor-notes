using System;

namespace for_example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) 
                    continue;
                else
                    Console.WriteLine(i);
            }
            
        }
    }
}
