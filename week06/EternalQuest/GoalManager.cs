class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
        Start();
        
    }

    public void DisplayMenu()
    {   string selected = "0";
        while(selected != "6")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            selected = Console.ReadLine();
            if (selected == "1")
            {
                CreateGoal();   
            }

            else if ( selected == "2")
            {   int count = 0;
                foreach (Goal goal in _goals)
                {
                    count += 1;
                    string statusComplete = "[ ]";
                    if (goal.IsComplete() == true)
                    {
                        statusComplete = "[X]";
                    }
                    if (goal is ChecklistGoal)
                    {
                        Console.WriteLine($"{count}. {statusComplete} {goal.GetName()} ({goal.GetDescription()}) {goal.GetDetailsString()} \n");
                    }
                    else
                    {
                        Console.WriteLine($"{count}. {statusComplete} {goal.GetName()} ({goal.GetDescription()}) \n");
                    }

                }   
                    DisplayPlayerInfo();
            }

            else if ( selected == "3")
            {
                SaveGoals();
            }

            else if ( selected == "4")
            {
                LoadGoals();
            }

            else if ( selected == "5")
            {
                RecordEvent();
            }
            }
        }
    public void Start()
    {      
        DisplayMenu();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
         
    }
    public void ListGoalName()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        if (goalType == "1")
        {
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            
            Goal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Goal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "3")
        {
            int amountCompleted = 0;
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Goal newGoal = new ChecklistGoal(name, description, points, target,amountCompleted, bonus);
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count += 1;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        _goals[choice - 1].RecordEvent();
        var selected = _goals[choice - 1];
            if (selected is SimpleGoal)
            {
                _score += int.Parse(selected.GetPoints());
            }
            else if (selected is EternalGoal)
            {
                _score += int.Parse(selected.GetPoints());
            }
            else if (selected is ChecklistGoal)
            {
                _score += int.Parse(selected.GetPoints());
                if (selected.IsComplete() == true)
                {
                    _score += int.Parse(((ChecklistGoal)selected).GetBonus().ToString());
                }
            }
        Console.WriteLine($"Congratulations! You have earned {selected.GetPoints()} points!\n");
        Console.WriteLine($"You now have {_score} points.\n");
            
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach ( string item in lines.Skip(1))
        {
            string[] parts = item.Split(':');
            if (parts[0] == "SimpleGoal")
            {
                string[] goalParts = parts[1].Split(',');
                Goal newGoal = new SimpleGoal(goalParts[0], goalParts[1], goalParts[2]);
                _goals.Add(newGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string[] goalParts = parts[1].Split(',');
                Goal newGoal = new EternalGoal(goalParts[0], goalParts[1], goalParts[2]);
                _goals.Add(newGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string[] goalParts = parts[1].Split(',');
                Goal newGoal = new ChecklistGoal (goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]));
                _goals.Add(newGoal);
                
            }
        }
    }
}
