using System;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void MenuDisplay(string[] array)
    {
        foreach(string line in array)
        {
            Console.WriteLine(line);
        }
    }

    static void GoalDisplay(List<Goal> goalList)
    {
        for(int i = 0; i<goalList.Count; i++)
        {
            Console.Write($"{i+1}. ");
            goalList[i].Display();
        }
    }
    static void Main(string[] args)
    {
        string userIn;
        string title;
        string description;
        string fileName;

        int value;
        int goalIndex;
        int completeReq; //completion requirement for checklist goals
        int bonusPoints;
        int pointsEarned;
        int points = 0;

        bool done = false;
        bool error = false;
        bool hasError=false;

        //loading indices
        int typeIndex=0;
        int titleIndex=1;
        int descIndex=2;
        int pointIndex=3;

        List<Goal> goals = new List<Goal>();

        string[] goalTypes = [
            "Goal Types",
            "    1. Basic",
            "    2. Eternal",
            "    3. Checklist"
        ];

        string[] menu = [
            "Menu Options:",
            "    1. Create New Goal",
            "    2. List Goals",
            "    3. Save Goals",
            "    4. Load Goals",
            "    5. Record Event",
            "    6. Quit"
        ];
        while (!done)
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            if (error)
                {
                    error=false;
                    Console.WriteLine("Invalid input.");
                }
            MenuDisplay(menu);
            Console.Write("Select a choice from the menu: ");
            userIn = Console.ReadLine();
            if (userIn == "1")
            {
                bool finished;
                do{
                MenuDisplay(goalTypes);
                Console.Write("Select a goal type: ");
                userIn=Console.ReadLine();
                finished=true;
                if (userIn == "1" || userIn=="2")
                {
                    Console.Write("Enter the goal name: ");
                    title = Console.ReadLine();
                    Console.Write("Enter a description for your goal: ");
                    description = Console.ReadLine();
                    Console.Write("Enter a point value: ");
                    value = int.Parse(Console.ReadLine());
                    if (userIn=="1")
                    {
                        goals.Add(new Basic(description, title, value));
                    }
                    else if (userIn == "2")
                    {
                        goals.Add(new Eternal(description, title, value));
                    }
                }
                else if (userIn == "3")
                    {
                        Console.Write("Enter the goal name: ");
                        title = Console.ReadLine();
                        Console.Write("Enter a description for your goal: ");
                        description = Console.ReadLine();
                        Console.Write("Enter a point value: ");
                        value = int.Parse(Console.ReadLine());
                        Console.Write("Enter the number of times you must complete the goal for a bonus: ");
                        completeReq=int.Parse(Console.ReadLine());
                        Console.Write("Enter the bonus for completing the requirement: ");
                        bonusPoints=int.Parse(Console.ReadLine());
                        goals.Add(new Checklist(description, title, value, completeReq, bonusPoints));
                    }
                else{
                    Console.WriteLine("Invalid input.");
                    finished=false;
                    }
                }while(!finished);
            }
            else if (userIn == "2")
            {
                GoalDisplay(goals);
            }
            else if (userIn == "3")
            {
                Console.Write("Input the save file: ");
                fileName=Console.ReadLine();
                using(StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(points);
                    foreach(Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.MakeString());
                    }
                }
            }
            else if (userIn == "4")
            {
                do{
                    try{
                        Console.Write("Input the load file: ");

                        fileName=Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(fileName);
                        for(int i=0;i<lines.Count();i++)
                        {
                            if(i==0)
                            {
                                points=int.Parse(lines[i]);
                            }
                            else
                            {
                                string[] goalData = lines[i].Split(",");
                                if (goalData[typeIndex] == "basic")
                                {
                                    goals.Add(new Basic(goalData[descIndex], goalData[titleIndex], int.Parse(goalData[pointIndex]), bool.Parse(goalData[4])));
                                    hasError=false;
                                }
                                else if (goalData[typeIndex] == "eternal")
                                {
                                    goals.Add(new Eternal(goalData[descIndex], goalData[titleIndex], int.Parse(goalData[pointIndex]), int.Parse(goalData[4])));
                                    hasError=false;
                                }
                                else
                                {
                                    goals.Add(new Checklist(goalData[descIndex], goalData[titleIndex], int.Parse(goalData[pointIndex]), int.Parse(goalData[6]), int.Parse(goalData[7]), bool.Parse(goalData[4]), int.Parse(goalData[8])));
                                    hasError=false;
                                }
                            }
                        }
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        hasError=true;
                        Console.WriteLine("Invalid load file.");
                    }
                }while(hasError);
            }
            else if (userIn == "5")
            {
                GoalDisplay(goals);
                Console.Write("Indicate the completed goal: ");
                goalIndex=int.Parse(Console.ReadLine());
                pointsEarned = goals[goalIndex-1].Mark();
                points+=pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {points} points.");
                Console.WriteLine();
            }
            else if (userIn == "6")
            {
                done=true;
            }
            else
            {
                error=true;
            }
        }
    }
}