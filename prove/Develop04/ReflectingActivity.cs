using System;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public static void Start()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Starting Reflecting Activity:");
        string randomPrompt = GetRandomItem(_prompts);
        Console.WriteLine(randomPrompt);

        // Implement reflecting activity logic here

        DisplayEndingMessage();
    }

    private string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int index = random.Next(items.Count);
        return items[index];
    }
}
