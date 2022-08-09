using System;

namespace ifElse_example_longest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score =Int32.Parse( Console.ReadLine());
            string result;
            /*
            if (score < 50)
            {
                result = "You failed.";
            }
            else
            {
                result = "You passed.";
            }
            */
            // this is ternary operator
            // variable = (condition) ? true_statement : false_statement;
            result = (score < 50) ? "You failed." : "You passed.";
            Console.WriteLine(result);  

        }
    }
}
