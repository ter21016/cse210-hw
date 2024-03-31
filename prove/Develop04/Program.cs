using System;

class Program
{
    static void Main(string[] args)
   {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
               case "1":
                    BreathingActivity.Start();
                    break;
                case "2":
                    ReflectingActivity.Start();
                    break;
                case "3":
                    ListingActivity.Start();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }
        }
   }
}