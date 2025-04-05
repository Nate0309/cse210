public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
    }

    public Activity(string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine($"Congratulations! You have completed the {_name} activity.");
        Console.WriteLine($"You have completed {_duration} seconds of the activity.");
    }

    public void ShowSpinner(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime) {
            Console.Write(spinner[index]);
            Console.Write("\b"); // Erase the last character
            index = (index + 1) % spinner.Length;
            System.Threading.Thread.Sleep(500); // Adjust the speed of the spinner
        }
        Console.WriteLine(); // Move to the next line after the spinner is done
    }

    public void ShowCountDown(int seconds){
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime) {
            TimeSpan timeLeft = endTime - DateTime.Now;
            Console.Write($"\r{timeLeft.Seconds} seconds left... ");
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second
        }
        Console.WriteLine(); // Move to the next line after the countdown is done
    }
}