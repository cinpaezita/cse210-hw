using System;


class Program
{
    static void Main(string[] args)
    {
        //Journal theJournal = newJournal();
        //PromptGenerator promptGenerator = new PromptGenerator();

        //Menu
        while(true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
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


            }

            else if (option == "2")
            {
                //Display all entries

            }

            else if (option == "3")
            {
                //Load the journal

            }

            else if (option == "4")
            {
                //Save the journal

            }

            else if (option == "5")
            {
                //Exit the program

            }

            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}