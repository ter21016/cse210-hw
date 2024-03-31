public class ListingActivity : Activity
{
    private static List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public static void Start()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Starting Listing Activity:");
        string randomPrompt = GetRandomItem(_prompts);
        Console.WriteLine(randomPrompt);

        // Implement listing activity logic here

        DisplayEndingMessage();
    }

    private string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int index = random.Next(items.Count);
        return items[index];
    }
}