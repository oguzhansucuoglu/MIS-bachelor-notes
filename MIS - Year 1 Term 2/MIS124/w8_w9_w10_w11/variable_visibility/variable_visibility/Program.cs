using System;

namespace variable_visibility
{
    class Program
    {
        static void Main(string[] args)
        {   //this is the outer block

            int number1 = 100;
            Console.WriteLine("the number1 is at outer block: {0}", number1);
            {   // this is an inner block
                // the variables which defined in the outer block are visible also in inner block.
                Console.WriteLine("the number1 is at inner block: {0}", number1);


                Console.WriteLine("the number1 value is changing in the inner block...");
                // changing value of the variable number1 in the inner block
                number1 = 110;
                Console.WriteLine("the number1 is at inner block: {0}", number1);
            }
            /*
            * If the value of a variable defined in the outer block is changed in the inner block, 
            * this change will take effect both in the inner block and the outer block.
            */
            Console.WriteLine("the number1 is at outer block: {0}", number1);
        }
    }
}
