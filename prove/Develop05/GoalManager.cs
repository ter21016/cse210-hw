using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private const int V = 2;
    private List<Goal> Goals = new List<Goal>();
    private int Score = 0;

    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();
           
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Menu Items:\n"
                        + "\t1. Create New Goal\n"
                        + "\t2. List Goals\n"
                        + "\t3. Save Goals\n"
                        + "\t4. Load Goals\n"
                        + "\t5. Record Event\n"
                        + "\t6. Quit");
        Console.Write("Select a choice from the menu:");
    }

    private int GetMenuChoice()
    {
        return int.Parse(Console.ReadLine());
    }

    
    private void CreateNewGoal()
{
    Console.WriteLine("The types of Goals are:\n"
            + "\t1. Simple Goal\n"
            + "\t2. Eternal Goal\n"
            + "\t3. Checklist Goal");
    Console.Write("Which type of goal would you like to create?");
    int type = int.Parse(Console.ReadLine());

    Console.Write("Enter goal name: ");
    string name = Console.ReadLine();
    
    Console.Write("Enter goal description: ");
    string description = Console.ReadLine();
    
    Console.Write("Enter points associated with this goal: ");
    string points = Console.ReadLine();
    
    switch (type)
    {
        case 1:
            Goals.Add(new SimpleGoal(name, description, points));
            break;
        case 2:
            Goals.Add(new EternalGoal(name, description, points));
            break;
        case 3:
            Console.Write("Enter target for the checklist goal: ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("Enter bonus points for the checklist goal: ");
            int bonus = int.Parse(Console.ReadLine());
            
            Goals.Add(item: new ChecklistGoal(name, description, points, target, bonus));
            
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}


 

    private void RecordEvent()
    {
      
        Console.Write("\nWhich goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Score += Goals[choice - 1].RecordEvent();
        Console.WriteLine($"\nYour current score is: {Score}\n");
    }

    private void SaveGoals()
    {
        Console.Write("Enter the file name to save goals (without extension): ");
        string fileName = Console.ReadLine() + ".txt";
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Goal goal in Goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter the file name to load goals (without extension): ");
        string fileName = Console.ReadLine() + ".txt";
        Goals.Clear(); // Clear existing goals before loading
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] data = line.Split(':');
                Goals.Add(Goal.CreateGoal(data));
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
    }
}
