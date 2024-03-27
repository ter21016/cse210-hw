using System;

public class ListingActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Starting Listing Activity:");
        string randomPrompt = GetRandomItem(_prompts);
        Console.WriteLine(randomPrompt);

        Console.WriteLine("You have 30 seconds to list as many items as you can...");
        Thread.Sleep(30000); // Pause for 30 seconds

        Console.WriteLine("Time's up!");

        DisplayEndingMessage();
    }

    private string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int index = random.Next(items.Count);
        return items[index];
    }
}