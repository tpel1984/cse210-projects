using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numberList = new List<>();
        var escapeInt = 0;
        var num = 1;

        while (num != escapeInt)
        {
            Console.WriteLine("Enter a number, or enter 0 to finish: ");
            num = int.Parse(Console.ReadLine());

            numberList.Add(num);
        }

        var sum = 0;

        foreach (int n in numberList) {
            sum += n;
        }

        var avg = sum / numberList.Count;

        var max = -1;
        for (int i = 0; i < numberList.Count; i++)
        {
            if (numberList[i] > max)
            {
                max = numberList[i];
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest number: {max}");
    }
}