using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {

            string name = "Xevious Green.";

            string location = " San Antonio, Texas.";


            DateTime thisDay = DateTime.Today;

            Console.WriteLine("Todays date is " + thisDay.ToString("d"));

            Console.WriteLine("My name is " + name);

            Console.WriteLine("I am from" + location);


        }



    }
}
