using System;

namespace implicit_data_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 18;
            Console.WriteLine("byte number =" + number);
            /*
             * The following conversion will be done automatically 
             * by the compiler successfully.
             * Because the data type conversion is made 
             * from the byte data type with a small number range 
             * to the short data type with a large number range.
             * This conversion named as Implicit Data Type Conversion.
            */
            short number2 = number;
            Console.WriteLine("short number =" + number2);



            short number3 = 18;
            Console.WriteLine("short number =" + number3);
            /*
             * The following conversion will not be possible.
             * Because data type conversion is made 
             * from short data type with large number range 
             * to byte data type with small number range.
             * so the compiler will throw an error.
            */
            byte number4 = number3;
            Console.WriteLine("byte number =" + number4);
        }
    }
}
