using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(6, 30);
        Console.WriteLine(run.GetSummary());
        Cycling cycle = new Cycling(15, 30);
        Console.WriteLine(cycle.GetSummary());
        Swimming swim = new Swimming(19, 30);
        Console.WriteLine(swim.GetSummary());
    }   
}