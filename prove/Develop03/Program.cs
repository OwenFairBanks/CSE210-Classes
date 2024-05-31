using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the list of avaliable scriptures:\n" +
        "\n1. Poverbs 3:5-6\n2. Jacob 3:2\n3. 3 Nephi 18:15\n4. " +
        "Galatians 4:1-2\n5. Matthew 7:1-2\n");
        Console.Write("Please enter an number (1-5): ");
        int num = int.Parse(Console.ReadLine());
        Scripture s1 = new Scripture(num);
        Reference r1 = new Reference(num);
        string script = s1.Get_Scripture();
        Console.Clear();
        Console.WriteLine($"\n{r1.Get_Reference()} {s1.Get_Scripture()}");
        Console.Write("\nPlease enter to continue or 'quit' to finish: ");
        string user_input = Console.ReadLine();
        string[] text = script.Split(' ');
        int amount = text.Length;
        Remover rt = new Remover(script, amount);
        while ( user_input != "quit" ) 
        {
            Console.Clear();
            Console.WriteLine($"\n{r1.Get_Reference()} {rt.Remove_Text()}");
            Console.Write("\nPlease enter to continue or 'quit' to finish: ");
            user_input = Console.ReadLine();
            user_input = user_input.ToLower();
        }
    }
}