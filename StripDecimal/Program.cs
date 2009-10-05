using System;
namespace StripDecimal
{
    class RemoveDecimal
    {
        static void Main(string[] args)
        {
            double testNum = 255.95;
            string noDecimalVal = testNum.ToString().Replace(".", "").PadLeft(9, '0');

            Console.WriteLine("Original Value: " + testNum.ToString());
            Console.WriteLine("Value w/No Decimal: " + noDecimalVal);
        }
    }
}