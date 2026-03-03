using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();

        myFirstJob._companyName = "Digitran";
        myFirstJob._jobTitle = "Software Engineer";
        myFirstJob._startYear = 1989;
        myFirstJob._endYear = 1994;

        myFirstJob.DisplayJob();

        Job mySecondJob = new Job();
        mySecondJob._companyName = "HP";
        mySecondJob._jobTitle = "Software Engineer";
        mySecondJob._startYear = 1994;
        mySecondJob._endYear = 2022;
        mySecondJob.DisplayJob();
    }
}