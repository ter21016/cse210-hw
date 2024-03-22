using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
       Console.WriteLine(a1.GetSummary());

       MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
       Console.WriteLine(a2.GetSummary());
       Console.WriteLine(a2.GetHomerworkList());

       WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of the World War II");
       Console.WriteLine(a3.GetSummary());
       Console.WriteLine(a3.GetWritingInformation());

    }
}