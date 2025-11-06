using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobOne = new Job();
        jobOne._startYear = 2019;
        jobOne._endYear = 2022;
        jobOne._company = "Microsoft";
        jobOne._jobTitle = "Software Engineer";
        jobOne.Display();

        Job jobTwo = new Job();        
        jobTwo._startYear = 2022;
        jobTwo._endYear = 2023;
        jobTwo._company = "Apple";
        jobTwo._jobTitle = "Manager";
        jobTwo.Display();

        Resume myResume = new Resume();
        myResume._jobs.Add(jobOne);
        myResume._jobs.Add(jobTwo);
        myResume._name = "Tom";
        myResume.Display();
    }
}