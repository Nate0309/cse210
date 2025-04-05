public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration)
        :base(name, description, duration)
    {
    }

    public void Run(){
        DisplayStartingMessage();
        ShowSpinner(3);

        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
    

    public string GetRandomPrompt(){
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion(){
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt(){
        Console.WriteLine("\nReflect on the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("Press enter when you are ready to continue...");
        Console.ReadLine();
    }

    public void DisplayQuestion(){
        Console.WriteLine($"\n> {GetRandomQuestion()}");
    }
}