using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your guess?");
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber == magicNumber){
            Console.WriteLine("You guessed it!");
        }
        else if(guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
    }
}