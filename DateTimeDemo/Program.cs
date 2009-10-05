using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeDemo
{
    class DateConv
    {
        static void Main(string[] args)
        {
            // Current Date/Time
            Console.WriteLine("Using Now Property           --> " + DateTime.Now);
            Console.WriteLine("Using Today Property         --> " + DateTime.Today);

            // DateTime in a text format
            string datetimeString = "6/2/2006 12:00:00 PM";
            Console.WriteLine("Text Formatted Date and Time --> " + datetimeString);

            // Convert the text DateTime to a DateTime format
            // This is just to show the syntax involved in a text to DateTime conversion
            DateTime convertedDateTime = DateTime.Parse(datetimeString);
            Console.WriteLine("Converted to DateTime        --> " + convertedDateTime);

            // Extract just the date portion of the DateTime variable
            string justDate = convertedDateTime.Date.ToShortDateString();
            Console.WriteLine("Extract Date Only:           --> " + justDate);

            // Once the variable is in DateTime format - several different variations
            Console.WriteLine("d: {0:d}", convertedDateTime);
            Console.WriteLine("D: {0:D}", convertedDateTime);
            Console.WriteLine("f: {0:f}", convertedDateTime);
            Console.WriteLine("F: {0:F}", convertedDateTime);
            Console.WriteLine("g: {0:g}", convertedDateTime);
            Console.WriteLine("G: {0:G}", convertedDateTime);
            Console.WriteLine("m: {0:m}", convertedDateTime);
            Console.WriteLine("M: {0:M}", convertedDateTime);
            Console.WriteLine("r: {0:r}", convertedDateTime);
            Console.WriteLine("R: {0:R}", convertedDateTime);
            Console.WriteLine("s: {0:s}", convertedDateTime);
            Console.WriteLine("t: {0:t}", convertedDateTime);
            Console.WriteLine("T: {0:T}", convertedDateTime);
            Console.WriteLine("u: {0:u}", convertedDateTime);
            Console.WriteLine("U: {0:U}", convertedDateTime);
            Console.WriteLine("y: {0:y}", convertedDateTime);
            Console.WriteLine("Y: {0:Y}", convertedDateTime);
        }
    }
}