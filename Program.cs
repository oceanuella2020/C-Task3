using System;

namespace csharp_task3
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] GameLevel = new string[3] { "Easy", "Medium", "Hard" };
            string Level;
            Console.WriteLine("Hello !");
            Console.WriteLine("This is a number guessing game with three levels.");
            Console.WriteLine(GameLevel[0]);
            Console.WriteLine(GameLevel[1]);
            Console.WriteLine(GameLevel[2]);
            Console.Write ("Choose any of your Prefered level: ");
            Level = Console.ReadLine();
            if (Level == GameLevel[0]) 
            {
                Easy();
            }
            else if (Level == GameLevel[1]) 
            {
                Medium();
            }
            else if (Level == GameLevel[2]) 
            {
                Hard();
            }
            else 
            {
                Console.WriteLine("Invalid Level Choice.\nRestart the Game. ");  
            }
        }
        static void Easy()
        {
            int SecretNum = 6;
            int Guess = 0;
            int GuessCount = 0;
            int GuessLimit = 6;
            bool OutOfGuesses = false;

            Console.WriteLine("Welcome to Easy level.You can choose a random number from 1-10. Only one of this numbers is correct.");
            Console.WriteLine("You have only 6 guesses in this level. if you don't get the special number before your guess limit elapses,you lose the game.\nEnjoy.");

            while (Guess != SecretNum&&!OutOfGuesses)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.Write("Enter Guess: ");
                    Guess = Int32.Parse(Console.ReadLine());
                    if (Guess != 6)
                    {
                        Console.WriteLine("You got it wrong! ");
                    }
                    GuessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }

            }
            if (OutOfGuesses)
            {
                Console.WriteLine("Game Over! ");
            }
            else
            {
                Console.WriteLine("You got it right! ");
            }

            Console.ReadLine();
        }
        static void Medium() 
        {
            int SecretNum = 11;
            int Guess = 0;
            int GuessCount = 0;
            int GuessLimit = 4;
            bool OutOfGuesses = false;
            Console.WriteLine("Welcome to Medium level. You can choose a random number from 1-20. Only one of this numbers is correct.");
            Console.WriteLine("You have only 4 guesses in this level. if you don't get the special number before your guess limit elapses,you lose the game.\nEnjoy.");
            while (Guess != SecretNum && !OutOfGuesses)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.Write("Enter Guess: ");
                    Guess = Int32.Parse(Console.ReadLine());
                    if (Guess != 11)
                    {
                        Console.WriteLine("You got it wrong! ");
                    }
                    GuessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }

            }
            if (OutOfGuesses)
            {
                Console.WriteLine("Game Over! ");
            }
            else
            {
                Console.WriteLine("You got it right! ");
            }

            Console.ReadLine();
        }
        static void Hard()
        {
            int SecretNum = 38;
            int Guess = 0;
            int GuessCount = 0;
            int GuessLimit = 3;
            bool OutOfGuesses = false;
            Console.WriteLine("Welcome to Hard level. You can choose a random number from 1-50. Only one of this numbers is correct.");
            Console.WriteLine("You have only 3 guesses in this level. if you don't get the special number before your guess limit elapses,you lose the game.\nEnjoy.");

            while (Guess != SecretNum && !OutOfGuesses)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.Write("Enter Guess: ");
                    Guess = Int32.Parse(Console.ReadLine());
                    if (Guess != 38)
                    {
                        Console.WriteLine("You got it wrong! ");
                    }
                    GuessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }

            }
            if (OutOfGuesses)
            {
                Console.WriteLine("Game Over! ");
            }
            else
            {
                Console.WriteLine("You got it right! ");
            }

            Console.ReadLine();
        }
    }
}
