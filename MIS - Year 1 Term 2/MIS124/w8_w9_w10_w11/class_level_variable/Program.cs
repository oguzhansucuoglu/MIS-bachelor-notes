using System;

class student
{

    public static int student_id = 1;              //class level variable 
    public static string student_name = "Test";    //class level variable 

    public static void Main()
    {
        // accessing class level variables 
        Console.WriteLine(student_id);
        Console.WriteLine(student_name);

        student_name = "Test2"; // class variables can be modified later
        Console.WriteLine(student_name);

    }

    public void A()
    {
        // class level variables are visible in the entire class
        Console.WriteLine(student_id);
        Console.WriteLine(student_name);
    }

}