using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letterGrade = "";
        bool pass = true;
        Console.Write("Enter your grade (0-100): ");
        grade = Convert.ToInt16(Console.ReadLine());
        if (grade >= 90)
        {
            letterGrade += 'A';
        }
        else if (grade >= 80)
        {
            letterGrade += 'B';
        }
        else if (grade >= 70)
        {
            letterGrade += 'C';
        }
        else if (grade >= 60)
        {
            letterGrade += 'D';
            pass = false;
        }
        else
        {
            letterGrade += 'F';
            pass = false;
        }
        if (letterGrade != "F")
        {
            if (grade % 10 >= 7 && letterGrade != "A")
            {
                letterGrade += '+';
            }
            else if (grade % 10 < 3)
            {
                letterGrade += '-';
            }
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");
        if (pass)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you didn't pass. Better luck next time.");
        }
    }
}