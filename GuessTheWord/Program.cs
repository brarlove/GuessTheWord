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
            string guessWord = words[randomNum];
            int numOfCharsInWord = guessWord.Count();
            Console.WriteLine("Welcome to GuessTheWord. You have 4 chances to guess the letters of the word. Good Luck!");
            string underScore = "";
            string word = "";
            for(int i = 0; i < numOfCharsInWord; i++)
            {
                underScore += "_ ";
            }
            while(chances > 0)
            {
                Console.WriteLine(underScore);
                Console.WriteLine("Chances left: " + chances);
                Console.Write("Please guess the letter: ");
                char letterGuess = Convert.ToChar(Console.ReadLine());
                bool match = false;
                var positions = new List<int>();
                positions.Clear();
                for (int i = 0; i < guessWord.Length; i++)
                {
                    Console.WriteLine(guessWord[i]);
                    if (Convert.ToChar(guessWord[i]) == letterGuess)
                    {
                        match = true;
                        positions.Add(i);
                    }
                    else
                    {
                        match = false;
                    }
                }
                Console.WriteLine(false);
                if(match == false)
                {
                    chances--;
                }
                else
                {
                    foreach(var position in positions)
                    {
                        underScore.Remove(position, 1);
                        underScore.Insert(position, letterGuess.ToString());
                        Console.WriteLine("This letter is correct and goes at position: " + position);
                    }
                }
                if (chances == 0)
                {
                    Console.WriteLine("Sorry you lost. The correct word is: " + guessWord);
                }
            }
        }
    }
}
