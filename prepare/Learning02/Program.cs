using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "firmware Engineer";
        job1._company = "intel";
        job1._startYear = 2016;
        job1._endYear = 2024;
        //job1.DisplayInfo();

        job job2 = new job();
        job2._jobTitle = "Janitor";
        job2._company = "Walmart";
        job2._startYear = 2011;
        job2._endYear = 2020;
        //job2.DisplayInfo();

        resume resume1 = new resume();
        resume1._name = "Dave";
        //resume1._jobs;
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        //Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.displayResume();
    }
}