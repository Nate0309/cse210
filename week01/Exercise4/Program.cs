using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }    
        }  while (number != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double ave = numbers.Average();
        Console.WriteLine($"The average is {ave}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");
    }
}