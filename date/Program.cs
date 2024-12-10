using System;
namespace ICT
{
    class Program
    {
        static void Main(string[] args)
        {

            // displaying the days
            string[] days = { "null", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("date selections :\n");
            int user;
            int i = 1;

            while (i < days.Length)
            {
                Console.WriteLine(days[i]);
                i++;
            }
            //=========================================================================================================


            //using loop in user input to prevent error
            while (true)
            {
                Console.Write("\nEnter a number between 1-7 : ");
                user = Convert.ToInt32(Console.ReadLine());

                //Using if/else to prevent the user not entering 1-7 numbers
                if (user < 1 || user > 7)
                {
                    Console.WriteLine("Invalid input. Try again");
                    //if the input is not between 1-7, the loop will start again and restart the question
                }
                else
                {
                    break;
                    //if the user input is valid the loop will break and proceed to the next line of code
                }
            }
            
            //do-while di ko gets yawa basta yan
            do
            {
                Console.WriteLine(days[user]);
                user++;
            }
            while (user > days.Length);
        }
    }
}
