// Creativity: The video "C# Programming Tutorial 46 - Methods to Search a List (Contains IndexOf, LastIndexOf)" by Caleb Curry
// helped me ensure that no random prompts or questions are selected until they have all been used at least once during that session
// in the Reflecting Activity. Link: https://www.youtube.com/watch?v=jB_HaLhdp0Y

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Thread.Sleep(2000);
            }
        }
    }
}