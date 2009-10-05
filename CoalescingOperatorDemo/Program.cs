using System;
namespace CoalescingOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "GabrielGray";
            string userName2 = null;

            string name = userName ?? "<no name>";
            string name2 = userName2 ?? "<no name>";

            Console.WriteLine(name);
            Console.WriteLine(name2);
        }
    }
}