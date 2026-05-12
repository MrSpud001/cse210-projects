using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "company 1";
        job1._startYear = "2035";
        job1._endYear = "2037";

        job2._jobTitle = "manager";
        job2._company = "company 2";
        job2._startYear = "2034";
        job2._endYear = "2038";


        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();

    }   
}