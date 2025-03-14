using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator newPrompt = new PromptGenerator();
        Journal addEntry = new Journal();
        

        int num = 0;
        do {
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entry");
            Console.WriteLine("5. Quit");
            num = int.Parse(Console.ReadLine());

            switch(num){
                case 1:    
                Entry newEntry = new Entry();         
                string prompt = newPrompt.GetRandomPrompt(); 
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();
                string date = DateTime.Now.ToString("dd-MM-yyyy");

                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entry = entry;
                addEntry._entries.Add(newEntry);
                break;
                case 2:
                    addEntry.DisplayAll();
                break;
                case 3:
                Console.WriteLine("What would you like to save it as?");
                string filename = Console.ReadLine();
                addEntry.SaveToFile($"{filename}.txt");
                break;
                case 4:
                Console.WriteLine("Which file would you like to read?");
                string readfile = Console.ReadLine();
                addEntry.LoadFromFile($"{readfile}.txt");
                break;
                case 5:
                Console.WriteLine("Goodbye!");
                break;
            }
        } while(num != 5);
    }
}