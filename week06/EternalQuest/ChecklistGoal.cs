public class ChecklistGoal : Goal{

    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _bonusAwarded;


    public ChecklistGoal(string name, string description, int points, int target, int bonus): base(name, description, points){
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations! You have earned {_points} points.");

        if (IsComplete() && !_bonusAwarded){
            Console.WriteLine($"You completed the goal! You have earned {_bonus} bonus points!");
            _bonusAwarded = true;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }   

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override int GetPoints()
    {
        int score = _points;
        if (IsComplete()){
            score += _bonus;
        }
        return score;
    }
}