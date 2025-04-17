public class Cycling : Activity {

    public Cycling (double distance, int time): base(distance, time){

    }


    public override double GetDistance()
    {
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
        return $"Cycling ({_time} min) - Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} km/h, Pace: {GetPace():0.00} min per km";
    }

}