public class BreathingActivity : Activity{


    public BreathingActivity(string name, string description, int duration) 
        :base(name, description, duration)
    {

    }

    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine("Get ready to start the breathing exercise");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        bool breatheIn = true;

        while(DateTime.Now < endTime) {
            if (breatheIn) {
                Console.WriteLine("Breathe in...");
                ShowCountDown(4);
                breatheIn = false;
            } else {
                Console.WriteLine("Breathe out...");
                ShowCountDown(7);
                breatheIn = true;
            }
        }
        DisplayEndingMessage();
    }
}