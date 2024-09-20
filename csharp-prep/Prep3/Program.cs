using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Console.Write("What is your guess? ");
        //int guessNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber > guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}