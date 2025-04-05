using System;

public class Program
{
    static void Main(string[] args)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("-------------------");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();
        if (choice == "4")
        {
            Console.WriteLine("Goodbye! Stay mindful ✨");
            break;
        }

        // Ask for the duration in seconds for all activities
        int duration = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            validInput = int.TryParse(input, out duration) && duration > 0;
            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }

        switch (choice)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.",
                    duration
                );
                breathing.Run();
                break;

            case "2":
                ReflectingActivity reflecting = new ReflectingActivity(
                    "Reflection",
                    "This activity will help you reflect on times when you have shown strength and resilience.",
                    duration
                );
                reflecting.Run();
                break;

            case "3":
                ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    duration
                );
                listing.Run();
                break;

            default:
                Console.WriteLine("Please choose a valid option.");
                break;
        }

        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}

}