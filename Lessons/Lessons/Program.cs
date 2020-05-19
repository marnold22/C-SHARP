using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1 - Hello World
            Console.WriteLine("Hello World!");
            Console.Write("\n");


            // Lesson 2 - WriteLine() vs Write()
            Console.WriteLine("WriteLine() will print on a new line each time.");
            Console.Write("Write() will print all on the same line. \n");
            Console.Write("\n");


            // Lesson 3 - Declaring Variables
            string name = "Michael";
            int age = 25;
            double height = 5.7D;
            bool male = true;
            Console.WriteLine("Hello my name is " + name + " and I am " + age + " years old");

            // Lesson 4 - C# Data Types
            int myIntNum = 5;                       // Integer - 4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long myLongNum = 15000000000L;          // Long - 8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float myFloatNum = 5.75F;               // Float - 4 bytes - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double myDoubleNum = 5.99D;             // Double - 8 bytes - Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool myBool = true;                     // Boolean - 1 bit - Stores true or false values
            char myLetter = 'A';                    // Character - 2 bytes - Stores a single character/letter, surrounded by SINGLE QUOTES
            string myText = "Hello";                // String - 2 bytes per character - Stores a sequence of characters, surrounded by DOUBLE QUOTES

            // SCIENTIFIC NUMS
            float f1 = 35e3F;           // The "e" is exponential (determines how many zeros)
            double d1 = 12E4D;          // The "E" is exponential (determines how many zeros)
            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}
