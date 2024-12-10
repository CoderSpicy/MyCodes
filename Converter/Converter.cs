using System;
namespace ICT
{
    class Converter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter\n");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter your choice (1 or 2): ");
            string user1 = Console.ReadLine();

            switch (user1)
            {
                case "1":
                    Console.Write("Enter temperature in Celsius: ");

                    string userCelsius = Console.ReadLine();
                    double celsius1;
                    if (!double.TryParse(userCelsius, out celsius1))
                    {
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                    }

                    double fahrenheit2 = (celsius1 * 9 / 5) + 32;
                    Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit2);
                    Console.ReadKey();

                    break;
                case "2":
                    Console.Write("Enter temperature in Fahrenheit: ");
                    string userFahrenheit = Console.ReadLine();
                    double fahrenheit1;
                    if (!double.TryParse(userFahrenheit, out fahrenheit1))
                    {
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                    }

                    double celsius2 = (fahrenheit1 - 32) * 5 / 9;
                    Console.WriteLine("The temperature in Celsius is: " + celsius2);
                    Console.ReadKey();

                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    break;
            }


        }
    }
}