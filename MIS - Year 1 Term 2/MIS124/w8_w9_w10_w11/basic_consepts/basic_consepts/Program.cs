using System;

namespace basic_concepts
{
    internal class Program
    {

   
        static void Main(string[] args)
        {
            Console.WriteLine("Name\nSurname"); // \n inserts a new line
            Console.WriteLine("My age:\t25");   // \t inserts a TAB space
            Console.WriteLine("This sentence consist of a \"double quote character");

            //this is variable declaration
            string student_name;

            // this is assignment a value to the variable
            student_name = "zeki";

            // this is both of decleration and assignment
            int student_age = 39;

            int 3name;          // wrong because it starts with a number
            string $surName;    // wrong because it starts with a special charecter
            string üğçöş;       // correct because variable names may consist of non-english characters


            int number_point = 65;
            // variable value can be changed later
            number_point = 100;

            const double pi = 3.14; // this is constant
            pi = 3.1418; // constant value cannot be changed later.


            uint number = 887876876;
            int number2 = -887876876;

            int result = (-34 * 4 + 6) / 3 - 2 * 5;
        }

 
    }
}
