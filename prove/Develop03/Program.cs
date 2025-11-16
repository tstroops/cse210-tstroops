using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        string userIn;
        bool invalid=false;
        Scripture s = new Scripture("For God so loved the world, that He gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.","John",3,16);
        
        for(int i=s.getLength()+1;i>0;i--)
        {
            Console.Clear();
            if (invalid)
            {
                Console.WriteLine("Your last input was invalid.");
                invalid=false;
            }

            s.Display();
            Console.Write("Press enter to continue or type 'quit' to quit: ");
            userIn = Console.ReadLine();
            
            if (userIn == "quit")
            {
                break;
            }
            else if (userIn == "")
            {
                s.HideWords();
            }
            else
            {
                invalid=true;
            }
        }
    }
}