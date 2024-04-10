using System;

class Program
{
    static void Main(string[] args)
    {
        // Create event objects
        Lecture lecture = new Lecture("The Power", "Womens Empowerment Summit", 
                                                new DateTime(2024, 4, 15, 14, 0, 0), "The Power", "Mary Jones", 100);
        Reception reception = new Reception("Throwback 90s Jam", "An evening of fun an socializing", 
                                                      new DateTime(2024, 4, 20, 18, 0, 0), "Sky and Rock", "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Glow-in-the-Dark Cereal Party", "a breakfast-themed event with neon decor", 
                                                                          new DateTime(2024, 5, 5, 11, 0, 0), "Ihop");

                                                                       

        // Display marketing messages for each event
        Console.WriteLine("Lecture Event Marketing Messages:");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event Marketing Messages:");
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event Marketing Messages:");
        Console.WriteLine(outdoorGathering.GenerateStandardDetails());
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}
