//Creativity: Create a list of references and scriptures. Select a scripture at random to present to the user.//
//I had issues when enetering "quit" with different capitalizations, so I researched how to use ToLower in C# to ensure it's always compared
//in lowercase, no matter how the user types it. Additionally, I used the Join method to concatenate strings with separator, improving readability.
//I found  both methods on the GeeksforGeeks website. Link: https://www.geeksforgeeks.org/c-sharp-join-method-set-1/
//Link: https://www.geeksforgeeks.org/c-sharp-tolower-method/
using System;

class Program
{
    static void Main(string[] args)
    {
        //1ST VERSION - A single reference to a scripture
        //Reference reference = new Reference("Proverbs", 3, 5, 6);
        //Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding, in all thy ways acknowledge him, and he shall direct thy paths.");

        //CREATIVITY - A list of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding, in all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gaved his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("1 John", 4, 19), "We love him, because he first loved us."),
            new Scripture(new Reference("Joshua", 24, 15), "And if it seem evil unto you to serve the LORD, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but us for me and my house, we will serve the LORD."),
        };
        //Randomly select a scripture from the list
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];
        //
        //To display and interact with the scripture
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string user = Console.ReadLine();

            if (user.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}