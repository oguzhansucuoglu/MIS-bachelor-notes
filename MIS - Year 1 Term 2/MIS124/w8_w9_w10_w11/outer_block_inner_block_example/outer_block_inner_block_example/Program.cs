using System;

namespace outer_block_inner_block_example
{
    internal class Program
    {
        static void Main(string[] args)
        {// this is outer block

            int number1 = 1;
            Console.WriteLine("number1 is " + number1);


            { //this is inner block
                Console.WriteLine("number1 is " + number1);

                int number2 = 2;
                Console.WriteLine("number2 is " + number2);
            } // end of inner block

            // the following lines belong to the outer block.
            Console.WriteLine("number1 is " + number1);
            // The following line will throw an error.
            // Because the variable number2 was defined in the inner block.
            // So it is not visible in the outer block.
            Console.WriteLine("number2 is " + number2);
        }
    }
}
