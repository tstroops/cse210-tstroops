using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(1,101);
        int numGuesses = 0;
        while (true)
        {
            numGuesses++;
            Console.Write("Guess the magic number: ");
            int guess = Convert.ToInt16(Console.ReadLine());
            if (guess == magicNum)
            {
                Console.WriteLine("That's correct");
                Console.WriteLine($"It took you {numGuesses} tries.");
                break;
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Too low");
            }
        }
    }
}