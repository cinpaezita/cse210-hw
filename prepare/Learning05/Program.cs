using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assg1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assg1.GetSummary());
        Console.WriteLine();

        MathAssignment assg2 = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(assg2.GetSummary());
        Console.WriteLine(assg2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assg3 = new WritingAssignment("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(assg3.GetSummary());
        Console.WriteLine(assg3.GetWritingInformation());
    }
}