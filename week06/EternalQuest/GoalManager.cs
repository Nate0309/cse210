public class GoalManager{
    private List<Goal> _goals;
    private int _score;


    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start(){
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Goal Manager ---");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create a Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames(){
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails(){
        foreach (Goal goal in _goals){
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(){
        Console.WriteLine("Choose a goal type to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter the target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for completing the goal: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void RecordEvent(){
        Console.WriteLine("Which goal would you like to report on?");
        ListGoalNames();
        Console.WriteLine("Please enter the number");
        int goalIndex = int.Parse(Console.ReadLine());
        int indexnum = goalIndex-1;
        if (indexnum >= 0 && indexnum < _goals.Count)
        {
            
            _goals[indexnum].RecordEvent();
            _score += _goals[indexnum].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals(){
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(){
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalData = parts[1].Split(',');

                if (goalType == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                }
                else if (goalType == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[3])));
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}