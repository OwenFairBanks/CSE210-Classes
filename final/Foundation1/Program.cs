using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the YouTube Video Generator");
        List<string> YT_Video_data = [];
        int user_input = 0;
        while (user_input != 5)
        {
            Console.WriteLine("Please select an option:\n1. Generate Videos"
            + "\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("Selected option: ");
            user_input = int.Parse(Console.ReadLine());
            if (user_input == 1)
            {
            Random r1 = new Random();
            int total = 0;
            int[] videos = [3,4,5];
            int randomIndex = r1.Next(videos.Length);
            int Total_Videos = videos[randomIndex];
            while (total != Total_Videos){
                Comments c1 = new Comments();
                c1._account = c1.GetAccount();
                c1._text = c1.GetText();
                Comments c2 = new Comments();
                c2._account = c2.GetAccount();
                c2._text = c2.GetText();
                Comments c3 = new Comments();
                c3._account = c3.GetAccount();
                c3._text = c3.GetText();
                Videos v1 = new Videos();
                v1._author = v1.GetAuthor();
                v1._title = v1.GetTitle();
                v1._length = v1.GetLength();
                v1._comments.Add(c1);
                v1._comments.Add(c2);
                v1._comments.Add(c3);
                v1.Report();
                YT_Video_data.Add($"\nVideo:\n{v1._title} ({v1._length}), from {v1._author}\nComments:\n"+
                $"{c1._account}: {c1._text}\n{c2._account}: {c2._text}\n{c3._account}: {c3._text}");
                total += 1;
                }
                Console.WriteLine("");
            }
            else if (user_input == 2)
            {
                foreach (var array in YT_Video_data)
                {
                    Console.WriteLine(array);
                }
            }
            else if (user_input == 3)
            {
                Console.Write("Textfile Name: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else if (user_input == 4)
            {
                Console.Write("Please create a textfile name: ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine("Generated YouTube Videos:");
                    foreach (var array in YT_Video_data)
                    {
                        outputFile.WriteLine(array);
                    }
                }     
            }
            else if (user_input == 5)
            {
                Console.WriteLine("We hope you enjoyed generating random videos!");
            }
            else
            {
                Console.WriteLine("That's not an option unfortunately");
            }
        }
    }
}