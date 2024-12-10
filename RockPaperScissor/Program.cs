using System;
namespace ICT
{
    class Game
    {
        static void Main(string[] args)
        {
            string[] player = { "0", "Rock", "Paper", "Scissors" };

            Console.WriteLine("Welcome to my game!\n");
            Console.WriteLine("Select '1' for Rock");
            Console.WriteLine("Select '2' for Paper");
            Console.WriteLine("Select '3' for Scissors");
            Console.Write("Enter a number: ");
            string decision = Console.ReadLine();

            string playersChoice = PlayersChoice(player, decision);
            string bot = BotDecision();

            Console.WriteLine("\nYou chose: " + playersChoice);
            Console.WriteLine("The bot chose: " + bot);

            string result = GameMechanics(playersChoice, bot);
            Console.WriteLine(result);
        }
        static string PlayersChoice(string[] player, string decision)
        {
            int decided;
            if (!int.TryParse(decision, out decided) || decided < 1 || decided > 3)
            {
                Console.WriteLine("\nInput must be 1-3");
                return "invalid";
            }
            return player[decided];
        }
        static string BotDecision()
        {
            string[] bot = { "Rock", "Paper", "Scissors" };
            Random botDecision = new Random();

            int index = botDecision.Next(bot.Length);

            return bot[index];
        }
        static string GameMechanics(string playersChoice, string bot)
        {
            if (playersChoice == "invalid")
            {
                Console.WriteLine("Retry the program.");
            }
            
            if (playersChoice == bot)
            {
                Console.WriteLine("DRAW");
            }

            if ((playersChoice == "Rock" && bot == "Scissors") ||
                 (playersChoice == "Paper" && bot == "Rock") ||
                 (playersChoice == "Scissors" && bot == "Paper" ))
            {
                return "\nYou WIN";
            }
            else
            {
                return "\nYou LOSE";
            }
        }
    }
}