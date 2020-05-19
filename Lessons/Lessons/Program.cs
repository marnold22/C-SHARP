﻿using System;

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
            int l4int = 5;                       // Integer - 4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long l4long = 15000000000L;          // Long - 8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float l4float = 5.75F;               // Float - 4 bytes - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double l4double = 5.99D;             // Double - 8 bytes - Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool l4bool = true;                     // Boolean - 1 bit - Stores true or false values
            char l4char = 'A';                    // Character - 2 bytes - Stores a single character/letter, surrounded by SINGLE QUOTES
            string l4string = "Hello";                // String - 2 bytes per character - Stores a sequence of characters, surrounded by DOUBLE QUOTES

            // SCIENTIFIC NUMS
            float f1 = 35e3F;           // The "e" is exponential (determines how many zeros)
            double d1 = 12E4D;          // The "E" is exponential (determines how many zeros)
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            // Lesson 5 - C# Type Casting
            // Type casting is when you assign a value of one data type to another type. In C# there are two types of casting:
            // 1. Implicit Casting (automatically) - converting a smaller type to a larger type size (char -> int -> long -> float -> double)
            // 2. Explicit Casting (manually) - converting a larger type to a smaller size type (double -> float -> long -> int -> char)

            // Implicit Casting
            int l5Iint = 9;
            double l5Idouble = l5Iint;       // Automatically casting: int -> double
            Console.WriteLine(l5Iint);       // Prints 9 
            Console.WriteLine(l5Idouble);    // Prints 9

            // Explicit Casting
            double L5Edouble = 9.75;
            int L5Eint = (int) L5Edouble;    // Manually casting: double -> int  ***Note this requires using () in front of the value
            Console.WriteLine(L5Edouble);    // Prints 9.75
            Console.WriteLine(L5Eint);       // Prints 9

            // Type Conversion Methods
            // Can convert data types with built-in methods: ToBoolean, ToDouble, ToString, ToInt32 (int) Toint64 (long)
            int l5int = 15;
            double l5double = 5.25;
            bool l5bool = true;
            Console.WriteLine(Convert.ToString(l5int));    // convert int to string
            Console.WriteLine(Convert.ToDouble(l5int));    // convert int to double
            Console.WriteLine(Convert.ToInt32(l5double));  // convert double to int
            Console.WriteLine(Convert.ToString(l5bool));   // convert bool to string

        }
    }
}
