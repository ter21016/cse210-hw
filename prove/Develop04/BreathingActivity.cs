using System;

public class BreathingActivity : Activity

{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Starting Breathing Activity:");
        for (int i = 0; i < _duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(2);
            Console.WriteLine("Breathe out...");
            ShowCountdown(2);
        }

        DisplayEndingMessage();
    }
}