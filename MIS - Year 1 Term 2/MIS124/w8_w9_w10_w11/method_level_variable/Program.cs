using System;

namespace method_level_variable
{
    class Program
    {
        public void A()
        {
            int number_A = 5; //this variable type is method-level variable
            Console.WriteLine(number_A);

            // number_B variable is only visible in method B
            Console.WriteLine(number_B);
        }

        public void B()
        {
            int number_B = 10; //this variable type is method-level variable
            Console.WriteLine(number_B);

            // number_A variable is only visible in method A
            Console.WriteLine(number_A);
        }

        static void Main(string[] args)
        {
            // number_A variable is only visible in method A
            Console.WriteLine(number_A);
            // number_B variable is only visible in method B
            Console.WriteLine(number_B);
        }
    }
}
