using System;
using System.Collections.Generic;

// Class to represent a single word in the scripture
public class ScriptureWord
{
    public string Word { get; private set; }
    public bool IsHidden { get; private set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "______" : Word;
    }
}

// Class to represent the reference of the scripture
public class ScriptureReference
{
    public string Reference { get; private set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }
}

// Class to represent the scripture itself
public class Scripture
{
    private readonly List<ScriptureWord> words = new List<ScriptureWord>();
    private Random random = new Random();

    public Scripture(string reference, string text)
    {
        // Split the text into words
        string[] wordArray = text.Split(' ');
        
        // Create ScriptureWord objects for each word
        foreach (string word in wordArray)
        {
            words.Add(new ScriptureWord(word));
        }
        
        // Create a ScriptureReference object
        ScriptureReference scriptureReference = new ScriptureReference(reference);
        
        // Display the full scripture
        DisplayScripture(scriptureReference);
    }

    // Method to display the scripture
    private void DisplayScripture(ScriptureReference reference, Console console)
    {
        Console.WriteLine($"Scripture Reference: {reference.Reference}\n");

        foreach (ScriptureWord word in words)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
    }

    // Method to hide random words
    public void HideRandomWords()
    {
        foreach (ScriptureWord word in words)
        {
            if (!word.IsHidden && random.Next(2) == 0) // Randomly hide words
            {
                word.Hide();
            }
        }

        Console.Clear(); // Clear the console
        DisplayScripture(null); // Display the updated scripture
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (ScriptureWord word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}

// Program class
class Program
{
    static void Main(string[] args)
    {
        // Example usage
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, text);

        // Continue hiding words until all are hidden
        while (!scripture.AllWordsHidden())
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}
