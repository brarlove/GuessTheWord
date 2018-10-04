using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]
{
                "trident",
                "apple",
                "google",
                "crest",
                "car",
                "phone"
};

            Random random = new Random();
            int randomNum = random.Next(0, 5);
            int chances = 4;
            bool win = false;
            string guessWord = words[randomNum];
            int numOfCharsInWord = guessWord.Count();
            Console.WriteLine("Welcome to GuessTheWord. You have 4 chances to guess the whole word. Good Luck!");
            while (chances > 0 && win == false)
            {
                Console.WriteLine("This word has " + numOfCharsInWord + " characters and you have " + chances + " chances left");
                string answer = Console.ReadLine();
                if (answer == guessWord)
                {
                    Console.WriteLine("Congratulations! You won!");
                    win = true;
                }
                else
                {
                    chances--;

                }

                if (chances == 0)
                {
                    Console.WriteLine("Sorry you lost. The correct word was " + guessWord);
                }
            }
        }
    }
}
