public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _score;
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine()) - 1;
        int goalPoints = _goals[select].GetPoints();
        AddPoints(goalPoints);
        _goals[select].RecordEvent();
        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }

    public void ListGoals()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("\nYour Goals are:");
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(_score); // Save Total Points
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation()); // Save goals list
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            int totalPoints = int.Parse(readText[0]); // read the first line of text file for total stored points
            _score = totalPoints;
            readText = readText.Skip(1).ToArray(); // skip the first line of text file to read goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);
                if (type == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(name, description, points);
                    AddGoal(sGoal);
                }
                else if (type == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(name, description, points);
                    AddGoal(eGoal);
                }
                else if (type == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(name, description, points, numberTimes, bonusPoints);
                    AddGoal(clGoal);
                }
            }
        }
    }
}

