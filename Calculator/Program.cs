using System;
namespace Calculator
{   
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the FIRST number: ");
                string user1 = Console.ReadLine();
                double num1;

                if (!double.TryParse(user1, out num1))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                Console.Write("Enter the SECOND number: ");
                string user2 = Console.ReadLine();
                double num2;

                if (!double.TryParse(user2, out num2))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                Console.WriteLine("------------------");
                Console.WriteLine("\t1. addition");
                Console.WriteLine("\t2. subtraction");
                Console.WriteLine("\t3. multiplication");
                Console.WriteLine("\t4. division");
                Console.Write("select an number to use operator: ");
                string o = Console.ReadLine();
                Console.WriteLine("------------------");

                double t = 0;

                switch (o)
                {
                    case "1":
                        t = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {t}");
                        break;
                    case "2":
                        t = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {t}");
                        break;
                    case "3":
                        t = num1 * num2;
                        Console.WriteLine($"{num1} × {num2} = {t}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            t = num1 / num2;
                            Console.WriteLine($"{num1} ÷ {num2} = {t}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Cannot be divided to 0.");
                            continue;
                        }
                    default:
                        Console.WriteLine("Invalid input.");
                        continue;

                }
            }
        }
    }
}