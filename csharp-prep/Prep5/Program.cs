using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PropmtUserName()
    {
        Console.Write("Please enter your name: ");
        string userIn = Console.ReadLine();
        return userIn;
    }

    static int PromptUserNumber()
    {
        int num;
        Console.Write("Please enter your favorite number: ");
        num = int.Parse(Console.ReadLine());
        return num;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int bYear = int.Parse(Console.ReadLine());
        return bYear;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void displayResult(string name, int num, int birthYear)
    {
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, the square of your number is {num}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string uname = PropmtUserName();
        int favNum = PromptUserNumber();
        int year = PromptUserBirthYear();
        int square = SquareNumber(favNum);
        displayResult(uname, square, year);
    }
}