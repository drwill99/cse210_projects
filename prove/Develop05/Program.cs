using System;

class Program
{
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 6);

        
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int typeChoice;
        if (int.TryParse(Console.ReadLine(), out typeChoice))
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal value: ");
            int value = int.Parse(Console.ReadLine());

            switch (typeChoice)
            {
                case 1:
                    goals.Add(new SimpleGoal(name, value));
                    break;
                case 2:
                    goals.Add(new EternalGoal(name, value));
                    break;
                case 3:
                    Console.Write("Enter checklist target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, value, targetCount));
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }


    }

    private static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }
    }

    private static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                sw.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value}");
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals()
    {
        goals.Clear();
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string name = parts[1];
                int value = int.Parse(parts[2]);

                switch (type)
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(name, value));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(name, value));
                        break;
                    case "ChecklistGoal":
                        int targetCount = int.Parse(parts[3]);
                        goals.Add(new ChecklistGoal(name, value, targetCount));
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {type}. Skipping.");
                        break;
                }


            }


        }


        Console.WriteLine("Goals loaded successfully.");
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Choose goal to record event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int goalChoice;
        if (int.TryParse(Console.ReadLine(), out goalChoice) && goalChoice >= 1 && goalChoice <= goals.Count)
        {
            goals[goalChoice - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal choice. Please try again.");
        }


    }


}