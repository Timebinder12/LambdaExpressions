using System;
using System.Security.Cryptography.X509Certificates;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            bool canConvert1 = false;
            bool canConvert2 = false;

            Console.WriteLine("Please enter two numbers.");
            Console.WriteLine("First Number:");
            canConvert1 = double.TryParse(Console.ReadLine(), out number1);

            while(canConvert1 == false)
            {
                Console.WriteLine("You entered an invalid number. Please try again.");
                canConvert1 = double.TryParse(Console.ReadLine(), out number1);
            }

            Console.WriteLine("Second Number:");
            canConvert2 = double.TryParse(Console.ReadLine(), out number2);

            while(canConvert2 == false)
            {
                Console.WriteLine("You entered an invalid number. Please try again.");
                canConvert2 = double.TryParse(Console.ReadLine(), out number2 );
            }

            var sumResult = (double x, double y) => x + y; 
            var multiplyResult = (double x, double y) => x * y;
            var smallerValue = (double x, double y) =>
            {
                if (x > y)
                    return y;
                else
                    return x;
            };

            Console.WriteLine($"The two numbers added using Lambda: {sumResult(number1, number2)}");
            Console.WriteLine($"The two numbers multiplied using Lambda: {multiplyResult(number1, number2)}");
            Console.WriteLine($"The smaller of the two numbers is: {smallerValue(number1, number2)}");


        }
    }
}