using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber ()
    {
        Console.WriteLine("Please enter your favourite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber (int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult (string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}