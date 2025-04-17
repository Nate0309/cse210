using System.Runtime.Versioning;
using Microsoft.VisualBasic.FileIO;

public abstract class Activity{

    protected double _distance;
    protected int _time;

    public Activity(int time){
        _time = time;
    }


    public Activity (double distance, int time){
        _distance = distance;
        _time = time;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();


    public abstract string GetSummary();


}