// Página web donde investigué sobre try-catch Link: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/exception-handling-statements
using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _playerScore = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Events \n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            Console.WriteLine($"\nYou have {_playerScore} points.\n");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Player actual score: " + _playerScore);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
        
    }
    public void ListGoalDetails()
    { 
        Console.WriteLine("The goals are:");
        int goalNumber = 1; //Start numbering from 1 :/
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{goalNumber}. {goal.GetDetailString()}");
            goalNumber++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: \n  1. Simple Goal \n  2. Eternal Goal \n  3. Checklist Goal");
        Console.Write("Which type of goal do you want to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Not valid type goal.");
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Your goals are:");
        ListGoalDetails();

        Console.Write("Which goal did you accomplish: ");
        string input = Console.ReadLine();

        try
        {
            int selectedGoal = int.Parse(input);
            if (selectedGoal >= 1 && selectedGoal <= _goals.Count)
            {
                Goal goalToRecord = _goals [selectedGoal - 1];
                goalToRecord.RecordEvent();

                 _playerScore += goalToRecord.GetPoints();
                Console.WriteLine($"Congratulations! You have earned {goalToRecord.GetPoints()} points!");
                Console.WriteLine($"You now have {goalToRecord.GetPoints()} points.");

            }

            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved succesfully in the file: " + fileName);
    }

    public void LoadGoals()
    {
        Console.Write("Write filename of the goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                
                if (parts.Length < 2)
                {
                    Console.WriteLine("Error: wrong line format.");
                    continue;
                }
                
                string goalType = parts[0];
                string[] goalData = parts[1].Split(',');

                if (goalType == "SimpleGoal")
                {
                    
                    if (goalData.Length < 4)
                    {
                        Console.WriteLine("Data missing for SimpleGoal.");
                        continue;
                    }
                    
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool IsComplete = bool.Parse(goalData[3]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (IsComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);   
                }
                else if (goalType == "EternalGoal")
                {
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);

                    _goals.Add(new EternalGoal(name, description, points)); 
                    
                }

                else if (goalType == "ChecklistGoal")
                {
                
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    int target = int.Parse(goalData[3]);
                    int bonus = int.Parse(goalData[4]);
                    int amountCompleted = int.Parse(goalData[5]);
                    
                
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                }
                

                
            }
        }
        else
        {
            Console.WriteLine("The file is not exist");
        }
    }

}