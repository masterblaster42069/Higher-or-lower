using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higher_or_lower
{
    internal class GuessingGame
    {
        private Random rand = new Random();

        public void StartGame()
        {
            while (true) 
            { 
                int num = rand.Next(1, 101);
                Console.WriteLine("Guess if the number is higher or lower than 50. Type '>' for higher and '<' for lower.");

                string input = Console.ReadLine();
                while (input != ">" && input != "<") 
                {
                    Console.WriteLine("Invalid input. Please type '>' for higher or '<' for lower.");
                    input = Console.ReadLine();
                }

                if ((num > 50 && input == ">") || (num < 50 && input == "<"))
                {
                    Console.WriteLine($"You are correct, the number was {num}.");
                }
                else if (num == 50)
                {
                    Console.WriteLine($"It's a draw! The number was exactly 50.");
                }
                else
                {
                    Console.WriteLine($"Sorry, you are wrong. The number was {num}.");
                }
            }
        }
    }
}
