using System;
namespace DelegateDemo
{
    public delegate void TestDelegate(string message);

    class Program
    {
        public static void Display(string message)
        {
            Console.WriteLine("");
            Console.WriteLine("The string entered is : " + message);
        }

        static void Main(string[] args)
        {
            //-- Instantiate the delegate
            TestDelegate t = new TestDelegate(Display);

            //-- Input some text
            Console.WriteLine("Please enter a string:");
            string message = Console.ReadLine();

            //-- Invoke the delegate
            t(message);
            Console.ReadLine();
        }
    }
}