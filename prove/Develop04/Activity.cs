using System;

public class Activity
{
     protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity:");
        Console.WriteLine(_description);
        Console.Write("Please enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done! You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000); 
    }

    public void ShowSpinner(int seconds)
    {
        // Implement spinner animation here
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}