using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "NTT Data Media";
        job1._startYear = 2025;
        job1._endYear = 2027;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Financial Analyst";
        job2._company = "Sage";
        job2._startYear = 2020;
        job2._endYear = 2032;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Nathan O'Moore";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.DisplayResume();
    }
}