using System;

namespace HelloWorld
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

        }
    }
}
