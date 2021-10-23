using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Madrid";
            string guessWord = "";
            int counter =0;
            int guessTray = 3;
            bool outOfGuesses = false;

            while (secretWord != guessWord && !outOfGuesses)
            {
                if(counter < guessTray)
                {
                    Console.Write("Enter your guess please : ");
                    guessWord = Console.ReadLine();
                    counter++ ;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose !!")
            }
            else
            {
                Console.Write("YOU WIN Bravoooooooo")
            }
            Console.ReadLine();
        }
    }
}
