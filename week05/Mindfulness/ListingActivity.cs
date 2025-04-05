public class ListingActivity : Activity{

    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        :base(name, description, duration)  
    {
       
    }

    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);


        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}