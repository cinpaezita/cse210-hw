using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string studentAnswer = Console.ReadLine();
        int percent = int.Parse(studentAnswer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        /// Stretch Challenge 1
        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        /// Stretch Challenge 2
        if (percent >= 93)
        {
            sign = "";
        }
        /// Stretch Challenge 1
         if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations. You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }

    }
}