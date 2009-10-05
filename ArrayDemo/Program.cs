using System;
using System.Collections.Generic;
using System.Text;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDim();
            Console.WriteLine("++++++++++++++++++");
            MultiDim();
            Console.ReadLine();
        }

        static void SingleDim()
        {
            string[] strCities = new string[4] { "Houston", "Austin", "Tuscon", "Sedona" };

            foreach (string str in strCities)
            {
                Console.WriteLine(str);
            }
        }

        static void MultiDim()
        {
            string[,] strCityStates = new string[,] { { "Houston", "TX" }, { "Austin", "TX" }, { "Tuscon", "AZ" }, { "Sedona", "AZ" } };

            Console.WriteLine(strCityStates[0, 0] + "," + strCityStates[0, 1]);
            Console.WriteLine(strCityStates[1, 0] + "," + strCityStates[1, 1]);
            Console.WriteLine(strCityStates[2, 0] + "," + strCityStates[2, 1]);
            Console.WriteLine(strCityStates[3, 0] + "," + strCityStates[3, 1]);
            Console.WriteLine(" ");

            foreach (string str in strCityStates)
            {
                Console.WriteLine(str);
            }
        }
    }
}