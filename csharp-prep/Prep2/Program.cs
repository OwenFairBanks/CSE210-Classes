using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\n\n\nWhat is your percentage? ");
        string user_input = Console.ReadLine();
        int x = int.Parse(user_input);
        Console.WriteLine("");
        if ( x >= 90 )
        {
            Console.WriteLine("You have an A");
        }
        else if ( x >= 80 )
        {
            Console.WriteLine("You have a B");
        }
        else if ( x >= 70 )
        {
            Console.WriteLine("You have a C");
        }
        else if ( x >= 60 )
        {
            Console.WriteLine("You have a d");
        }
        else
        {
            Console.WriteLine("You have a F");
        }
        if (x >= 70 )
        {
            Console.WriteLine("Congradulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry to inform you, but you have failed.");
        }
        Console.WriteLine("");
        //Just need some spacing here lol
    }
}