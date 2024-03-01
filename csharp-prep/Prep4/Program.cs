using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

         /*
        Assignment
        Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Core Requirements
        1. Compute the sum, or total, of the numbers in the list.
        2. Compute the average of the numbers in the list.
        3. Find the maximum, or largest, number in the list.
        */

        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished ");
        while (number != 0)
        {
            Console.WriteLine("Enter Number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum1 = numbers.Sum();
        Console.WriteLine($"The sum is: {sum1}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}") ;
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    


    }
}