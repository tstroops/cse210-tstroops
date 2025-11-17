using System;

class Program
{
    static void Main(string[] args)
    {
        //MathAssignment myMath = new MathAssignment("7.3","8-19","Roberto Rodrigues", "Fractions");
        //Console.WriteLine(myMath.GetHomeworkList());
        WritingAssignment myPaper = new WritingAssignment("The Causes of WW2", "Mary Waters", "European History");
        Console.WriteLine(myPaper.GetWritingInformation());
    }
}