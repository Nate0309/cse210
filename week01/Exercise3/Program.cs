using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());
        //user generated number
        
        string answer = "";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int guessNumber = 0;
            int guesses = 0;

                do
                {
                    Console.WriteLine("What is your guess?");
                    guessNumber = int.Parse(Console.ReadLine());

                    if(guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    guesses++;
                } while (!(guessNumber == magicNumber));

                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write($"You guessed {guesses} times!");
                }
            
            Console.WriteLine("Do you want to play again? (yes/no)");
            answer = Console.ReadLine();
            } while(answer == "yes");

            if(answer == "no")
            {
                Console.WriteLine("Thanks for playing!");
            }
    }
}