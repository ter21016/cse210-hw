using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you focus on your breath and relax your mind.") { }

    public static void Start()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run();
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Starting Breathing Activity:");
        // Implement breathing activity logic here

        DisplayEndingMessage();
    }
}
