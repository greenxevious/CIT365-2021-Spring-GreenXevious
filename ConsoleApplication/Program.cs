using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Where are you located?");
            string location = Console.ReadLine();

            DateTime today = DateTime.Today;
            DateTime Day = today;

            DateTime christmas = new DateTime(2020,12 ,25);
             TimeSpan timeframe = christmas - Day;

            string total = $"My name is {name}." + $" I am from {location}.";
            Console.WriteLine(total);
            Console.WriteLine($"Todays date is {Day:d}.");
            Console.WriteLine($"Time from today until Christmas is {timeframe.TotalDays} days away.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width?");

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height?");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }



    }
}
