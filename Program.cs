using System;

namespace Hello_World
{
    //class
    class Program
    {
        static void Main(string[] args)//class attributes - void means it doesn't return anything, all methods have to declare what they will return
        {
            //class method
            string helloWorldString = "Hello World";
            PrintString(helloWorldString);
            Console.ReadKey();//This stops the programme from closing
        }
        static void PrintString (string input)
        {
            //main method
            Console.WriteLine(input);
        }
    }
}
