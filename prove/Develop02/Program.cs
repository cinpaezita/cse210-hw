//Creativity involves handling a file that is being attempted to load but does not exist.
//Every time I tried to enter an invalid name, an error appeared. So, I researched on Google (link attached below)
//to ensure that the file exists using an if statement and else to handle those
//Check if a File exists in C# : https://www.tutorialspoint.com/check-if-a-file-exists-in-chash
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        //Menu
        while(true)
        {
            
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                //Create a new entry//
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string entryText = Console.ReadLine();


                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = entryText;

                theJournal.AddEntry(newEntry);

            }

            else if (option == "2")
            {
                //Display all entries
                theJournal.DisplayAll();

            }

            else if (option == "3")
            {
                //Load the journal
                Console.Write("Enter the filename to load the journal: ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }

            else if (option == "4")
            {
                //Save the journal
                Console.Write("Enter the filename to save the journal: ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
                

            }

            else if (option == "5")
            {
                //Exit the program
                break;
            }

            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}