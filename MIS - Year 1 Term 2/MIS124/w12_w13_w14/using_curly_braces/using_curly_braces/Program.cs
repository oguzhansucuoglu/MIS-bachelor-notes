using System;

namespace using_curly_braces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 10;
            int c = 20;
            if (a >= 5)
            {
                b = 30;
                c = 40;
            }

            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c);

        }
    }
}
