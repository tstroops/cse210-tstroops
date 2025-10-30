using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letterGrade = "";
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
        }
        else
        {
            letterGrade += 'F';
        }
        if (letterGrade != "F")
        {
            if (grade % 10 >= 7 && letterGrade != "A")
            {
                letterGrade += '+';
            }
            else if (grade%10 < 3)
            {
                letterGrade += '-';
            }
        }
        Console.WriteLine(letterGrade);
    }
}