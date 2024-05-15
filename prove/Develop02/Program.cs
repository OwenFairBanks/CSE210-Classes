using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        List<string> entries = [];
        int user_input = 0;
        while ( user_input != 5 )
        {
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            user_input = int.Parse(Console.ReadLine());
            if ( user_input == 1 )
            {
                Prompts prompt1 = new Prompts();
                Random rnd = new Random();
                int choice = rnd.Next(10);
                prompt1._choice = choice;
                Entry entry1 = new Entry();
                entry1._entryPrompt = prompt1.getquestion();
                Console.WriteLine(entry1._entryPrompt);
                Console.Write("> ");
                entry1._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string timeText = theCurrentTime.ToShortTimeString();
                entry1._entryDate = dateText;
                entry1._entryTime = timeText;
                entries.Add($"\nDate: {entry1._entryDate} - Time: {entry1._entryTime}\nPrompt: {entry1._entryPrompt}\n{entry1._entryText}");
            }
            else if ( user_input == 2 )
            {
                foreach (var array in entries)
                {
                    Console.WriteLine(array);
                }
            }
            else if ( user_input == 3 )
            {
                Console.Write("Textfile Name: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else if ( user_input == 4 )
            {
                Console.Write("Please create a textfile name: ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine("Journal Entry/ies:");
                    foreach (var array in entries)
                    {
                        outputFile.WriteLine(array);
                    }
                }     
            }
            else if ( user_input == 5 )
            {
                Console.WriteLine("Thank you for using the Journal!");
            }
            else 
            {
                Console.WriteLine("That is not an option.");
            }
        }
    }
}