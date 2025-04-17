public class Swimming : Activity {

    private int _laps;

    public Swimming (int laps, int time): base(time){
        _laps = laps;
    }


    public override double GetDistance()
    {
        _distance = _laps*(50.0/1000.0);

        return _distance;
    }

     public override double GetSpeed()
    {
        return _distance/_time * 60;
    }

    public override double GetPace()
    {
        return _time / _distance;
    }


    public override string GetSummary()
    {
        return $"Swimming ({_time} min) - Laps: {_laps}, Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} km/h, Pace: {GetPace():0.00} min per km";
    }

}