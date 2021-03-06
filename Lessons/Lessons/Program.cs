﻿using System;
using System.Linq;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1 - Hello World
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Hello World!");
            Console.Write("\n");


            // Lesson 2 - WriteLine() vs Write()
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("WriteLine() will print on a new line each time.");
            Console.Write("Write() will print all on the same line. \n");
            Console.Write("\n");


            // Lesson 3 - Declaring Variables
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            string name = "Michael";
            int age = 25;
            double height = 5.7D;
            bool male = true;
            Console.WriteLine("Hello my name is " + name + " and I am " + age + " years old");


            // Lesson 4 - C# Data Types
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
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
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
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


            // Lesson 6 - C# User Input
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // This uded the ReadLine() function
            /*Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Username is: " + username);*/


            // Lesson 7 - C# Operators
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // Standard Arithmetic Operators (+ - * / % ++ --)
            // Standard Comparitons Operators ( == != > < >= <=)
            // Logical Operators
            // 1.) && (AND) Returns true if both statements are true
            // 2.) || (OR) Returns true if one of the statements is true
            // 3.) ! (NOT) Reverse the result, returns false if result is true


            // Lesson 8 - C# Math
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // The Math class has many methods
            Math.Max(5, 10);    // Returns MAX value of the two values
            Math.Min(5, 10);    // Returns MIN value of the two values
            Math.Sqrt(64);      // Returns SQUARE-ROOT of value
            Math.Abs(-6);       // Returns ABSOLUTE-VALUE of value
            Math.Round(9.99);   // Returns ROUNDED number to nearest whole number


            // Lesson 9 - C# Strings
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string fname = "Michael";
            string lname = "Arnold";
            string fullName = string.Concat(fname, lname);                          // Concatinate two strings into one
            Console.WriteLine("The length of the txt string is: " + txt.Length);    // .length returns numeric value
            Console.WriteLine(fname.ToUpper());                                     // ToUpper -> upercase
            Console.WriteLine(fname.ToLower());                                     // ToLower -> lowercase
            Console.WriteLine(fullName);

            // String Interpolation
            string movie = "Starwars";
            string producer = "George Lucas";
            string sentence = $"The movie {movie} was produced by {producer}";      // String interpolation, which substitutes values of variables into placeholders in a string
            Console.WriteLine(sentence);

            // Access Strings
            string l9String = "Hello World";
            Console.WriteLine(l9String[0]);                     // Accesses the first value in the string "H"
            Console.WriteLine(l9String.IndexOf("W"));           // Find the index position of specified value "W" -> 6th position

            // Special Characters
            // \' -> escape character for SINGLE QUOTE
            // \" -> escape character for DOUBLE QUOTE
            // \\ -> escape character for BACKSLASH
            // \n -> NEW LINE
            // \t -> TAB
            // \b -> BACLSPACE
            string slogan = "We are the so-called \"Vikings\" from the north.";         // The  \" allows for "" to be in string
            Console.WriteLine(slogan);

            // Lesson 10 - C# If...Else
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
             * 
                if (condition 1)
                {
                    block of code that will be executed if condition 1 is TRUE
                }
                else if (condition 2)
                {
                    block of code that will be executed if condition 1 is FLASE and condition 2 is TRUE
                }
                else
                {
                    block of code that will be executed if condition 1 and condition 2 are both FALSE
                }

            */

            // This example will be false for both condition 1 & condition 2 so it will execute the else statement "Good Evening"
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // Ternary operator (short hand)
            // variable = (condition) ? expressionTrue : expressionFalse;
            // This example will execute "Good Evening"
            int hour = 20;
            string result = (hour < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            // Lesson 11 - C# Switch Statements
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // BREAK -> keyword it breaks out of the switch block.
            // DEFAULT -> keyword is optional and specifies some code to run if there is no case match:
            /*
           
                switch(expression) 
                {
                    case x:
                    // code block
                    break;
                    case y:
                    // code block
                    break;
                    default:
                    // code block
                    break;
                }
             
            */

            // In this example because the day is 3 the result will be "Wednesday"
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }


            // Lesson 12 - C# While Loops
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
             * The while loop loops through a block of code as long as a specified condition is True

                while (condition) 
                {
                    // code block to be executed
                }

            */
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            /*
             * The do/while loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

                do 
                {
                    // code block to be executed
                }
                while (condition)

            */
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k < 5);


            // Lesson 13 - C# For Loops
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            
                for (statement 1; statement 2; statement 3) 
                {
                  // code block to be executed
                }

            Statement 1 is executed (one time) before the execution of the code block.
            Statement 2 defines the condition for executing the code block.
            Statement 3 is executed (every time) after the code block has been executed.
            */
            for (int p = 0; p < 5; p++)
            {
                Console.WriteLine(p);
            }

            /*
             * Foreach loop, which is used exclusively to loop through elements in an array
            
                foreach (type variableName in arrayName) 
                {
                    // code block to be executed
                }

            */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }


            // Lesson 13 - C# Break & Continue
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // The break statement can also be used to jump out of a loop.

            // Break Example
            // In this example you will break out of the loop once z=4
            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                z++;
                if (z == 4)
                {
                    break;
                }
            }

            // Continue Example
            // In this example once j=4 it will j++ then continue to print line which will be one value ahead and then increment j again
            // Output looks like this 0 1 2 3 5 6 7 8 9 ** Notice it skipped "4"
            int j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }


            // Lesson 14 - C# Arrays
            // ------------------------------------------------------------------------------------------------------------------------------------------------------
            // To declare an array, define the variable type with square brackets []

            string[] motorcycles = { "Kawasaki", "Ducati", "Honda", "Aprilla"};
            Console.WriteLine(motorcycles[0]);                                      // This will access the first array element "Kawasaki"

            // Change an array element
            motorcycles[2] = "Harley";                                              // This will replace the 3rd item in the array from Honda -> Harley

            // Loop through array
            for (int m = 0; m < motorcycles.Length; m++)
            {
                Console.WriteLine(motorcycles[m]);
            }

            // Or you can use Foreach
            foreach(string m in motorcycles)
            {
                Console.WriteLine(m);
            }

            // Sort Arrays
            Array.Sort(motorcycles);            // This will sort motorcycles alphabetically
            foreach (string m in motorcycles)
            {
                Console.WriteLine(m);
            }

            // System.Linq Namespace
            // This namespace gives us access to useful array methods such as Min, Max, Sum
            // Need to add these lines above namespace of current application
            /*
                using System;
                using System.Linq;
            */
            int[] numArray = { 2, 4, 7, 9, 5, 6 };
            Console.WriteLine(numArray.Max());      // Returns largest value in array "9"
            Console.WriteLine(numArray.Min());      // Returns smallest value in array "2"
            Console.WriteLine(numArray.Sum());      // Returns sum of array elements

            // Otherways to create arrays
            /*
                // Create an array of four elements, and add values later
                string[] cars = new string[4];

                // Create an array of four elements and add values right away 
                string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

                // Create an array of four elements without specifying the size 
                string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

                // Create an array of four elements, omitting the new keyword, and without specifying the size
                string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

                // Declare an array
                string[] cars;

                // Add values, using new
                cars = new string[] {"Volvo", "BMW", "Ford"};

                // Add values without using new (this will cause an error)
                cars = {"Volvo", "BMW", "Ford"}
            */
        }
    }
}
