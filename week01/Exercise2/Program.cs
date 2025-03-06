using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings user, what percent did you receive for your test?");
        string grade = Console.ReadLine();
        int perc = int.Parse(grade);

        string letter = "";

        if (perc >= 90) 
        {
            letter = "A";
        }
        else if (perc >= 80)
        {
            letter = "B";
        }
        else if (perc >= 70)
        {
            letter = "C";
        }
        else if (perc >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (perc > 70)
        {
            Console.WriteLine($"Congratulations! You passed your test and received a(n) {letter}");
        }
        else
        {
            Console.WriteLine($"Sorry friend, you didn't pass this one. You only got a(n) {letter}. You'll get it next time;)");
        }

    }
}