using System;
namespace ICT
{
    class Program 
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Guess a number between 1-100.");
            int user = Convert.ToInt32(Console.ReadLine());

            while (user != randomNumber)
            {
                if (user < randomNumber)
                {
                    Console.WriteLine("Too low");
                    user = Convert.ToInt32(Console.ReadLine());

                }
                else if (user > randomNumber)
                {
                    Console.WriteLine("Too High");
                    user = Convert.ToInt32(Console.ReadLine());
                }
                
            }

            Console.WriteLine("Congratulations");

        }
    }

}