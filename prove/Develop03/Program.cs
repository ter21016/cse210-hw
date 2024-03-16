using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
       var scripture = new Scripture("John 3:16", " For God so loved the world, that he gave his only begotten son, that whoever believeth in him should not perish, but have everlasting life...");

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");

        // Continue hiding words until all are hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            // Hide a few random words and display the updated scripture
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
        }

        Console.WriteLine("Program ended.");
    }
}
