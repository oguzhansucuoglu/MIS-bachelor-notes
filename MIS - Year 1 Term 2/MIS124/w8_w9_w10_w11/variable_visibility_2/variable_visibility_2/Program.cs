using System;

namespace variable_visibility_2
{
    class Program
    {
        static void Main(string[] args)
        { // this is outer block

            { //this is inner block

                /*
                 * this is the local variable.
                 * number2 is only visible in the block in which it is defined inner block.
                */
                int number2 = 200;
                Console.WriteLine("the number2 is in the inner block: {0}", number2);
            } //end of inner block

            // The following lines belong to the outer block.
            // the compiler throws CS0103  error!!!
            // The name 'number2' does not exist in the current context
            Console.WriteLine("the number2 is in the outer block: {0}", number2);
        }
    }
}

