using System;


namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Olagoke Amiola";
            string location = "Atlanta";

            Console.WriteLine($"My name is {name} , I am from {location}");

            Console.WriteLine(DateTime.Now.ToString("M-d-yyyy"));

            DateTime Xmas = new DateTime(DateTime.Now.Year, 12, 25);
            TimeSpan diff = (Xmas - DateTime.Now);
            Console.WriteLine(diff.Days + " Days till Christmas.");



            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Input the width");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Input the height");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }
}