using System;

namespace block_level_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //OUTER BLOCK STARTS
                int x = 1;
                Console.WriteLine(x);

                {// INNER BLOCK STARTS
                    int y = 5;
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }// INNER BLOCK ENDS
                Console.WriteLine(x);
                Console.WriteLine(y);

                {// INNER BLOCK2 STARTS
                    Console.WriteLine(y);
                }

            }//OUTER BLOCK ENDS

        }
    }
}
