
class Program
{
    static void Main(string[] args)
    {
        // Create activity objects
        Running runningActivity = new Running(new DateTime(2024, 4, 10), 30, 3.0);
        Cycling cyclingActivity = new Cycling(new DateTime(2024, 4, 8), 45, 12.0);
        Swimming swimmingActivity = new Swimming(new DateTime(2024, 5, 3), 60, 10);

        // Create an array to hold activities
        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

