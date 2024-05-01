using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string user_input = Console.ReadLine();
        int key = int.Parse(user_input);
        int guess = -1;
        int amount = 0;
        while (key != guess)
        {
            Console.Write("\nWhat is your guess? ");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            amount += 1;
            if (key > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (key < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it!\nGuesses taken: {amount}");
            }
        }
    }
}
