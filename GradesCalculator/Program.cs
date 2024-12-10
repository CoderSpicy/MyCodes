using System;
using System.ComponentModel.Design;
namespace ICT
{
    class GradesCalculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number of student: ");
                string user1 = Console.ReadLine();
                int index1;

                if (!int.TryParse(user1, out index1))
                {
                    Console.WriteLine("Invalid input");
                }

                string[] students = new string[index1];
                int[] grades = new int[index1];

                for (int i = 0; i < students.Length; i++)
                {
                    Console.Write("\nEnter the name of student " + (i + 1) + ": ");
                    students[i] = Console.ReadLine();

                    Console.Write("Enter " + students[i] + " grades: ");
                    string user2 = Console.ReadLine();


                    if (!int.TryParse(user2, out grades[i]))
                    {
                        Console.WriteLine("\nInvalid input\n");
                        break;
                    }                   
                }

                Console.WriteLine("\nResult:");

                for (int i = 0; i < students.Length; i++)
                {
                    
                    Console.Write(students[i] + " - ");

                    if (grades[i] > 100)
                    {
                        Console.WriteLine("Grade must be 100 below");
                        
                    }
                    else if (grades[i] == 100)
                    {
                        Console.WriteLine("Perfect");
                        
                    }
                    else if (grades[i] < 75)
                    {
                        Console.WriteLine("Fail");

                    }
                    else if (grades[i] < 100)
                    {
                        Console.WriteLine("Pass");
                        
                    }                 
                    else
                    {
                        Console.WriteLine("Invalid input");

                    }
                }

                Console.ReadKey();
                break;

            }
        }
    }
}