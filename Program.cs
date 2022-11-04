using System;

namespace Starting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Avarage";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 20;

            // Declare variables
            double num01;
            double num02;
            double num03;
            
            // Get firt number
            Console.WriteLine("Chose a number of 0 to 10");
            num01 = Convert.ToDouble( Console.ReadLine());

            // Get second number
            Console.WriteLine("Chose a number of 0 to 10 again");
            num02 = Convert.ToDouble( Console.ReadLine());

            // Get third number
            Console.WriteLine("Chose a number of 0 to 10 one more time");
            num03 = Convert.ToDouble( Console.ReadLine());
            
            // Calculate and display the average
            double result = num01 + num02 + num03 / 3;
            
            Console.WriteLine("The average is " + result);

            // Wait before closing
            Console.ReadKey();

    
        }
    }
}