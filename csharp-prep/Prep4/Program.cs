using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        float sum = 0;
        int big = 0;
        int size = 0;
        while (true)
        {
            Console.WriteLine("Enter a number to add to the list (enter 0 to quit): ");
            int userin = Convert.ToInt16(Console.ReadLine());
            if (userin == 0)
            {
                break;
            }
            size++;
            numList.Add(userin);
        }
        foreach (int num in numList)
        {
            sum += num;
            if (big < num)
            {
                big = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float avg = sum / size;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest value is {big}");
    }
}