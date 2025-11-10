using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        int userIn;
        Menu start = new Menu();
        Entry iHadToAddThis = new Entry();
        Journal myJournal = new Journal();
        Console.WriteLine("Username ");
        myJournal._userName = Console.ReadLine();
        do
        {
            userIn = start.ProcessMenu();
            switch (userIn)
            {
                case 1:
                    iHadToAddThis.GetResponse();
                    myJournal.StoreResponse(iHadToAddThis);
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    //saves to a designated file
                    Console.WriteLine("Enter the name of the save file: ");
                    string saveFile = Console.ReadLine();
                    myJournal.Save(saveFile);
                    break;
                case 4:
                //load from a file
                    Console.WriteLine("Enter the name of the load file: ");
                    string loadFile = Console.ReadLine();
                    myJournal.Load(loadFile);
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}