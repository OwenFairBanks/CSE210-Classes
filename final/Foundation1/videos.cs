using System.Runtime.InteropServices;

public class Videos
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comments> _comments = new List<Comments>();

    List<string> titles = ["Star Wars: A New Hope Review","How to open a door",
    "Thoughts on Harry Potter", "How to Bake a Minecraft Cake!","CLICKBAIT!!",
    "Drawing Lesson: Eyes","Top 100 Fortnite Clips","Why I left my home (Emotional)",
    "C# Coding: Abstraction","What to bring for Deep Mountain Climbing",
    "What does the Fox Say?","Brick Ghastly - Always gonna Let You Down (Music Video)",
    "Tired of making up YouTube titles? Click here for assistance (Not a Scam)"];
    List<string> authors = ["Regular_Guy","Lapotop","NameLostXD","Jamzlii","Nephi_The_7th",
    "The_Three_Bears","LifEnjoyer","Your_Uber","Technoblade","Mcdonalds_Employee"];
    List<string> lengths = ["14:56","37:03","8:01","1:56:32","25:26","54:53",
    "4:43","2:15:30","9:09","15:42","17:00","2:05","25:31:56","42:29","5:55"];
    public string GetTitle()
    {
        Random r1 = new Random();
        int t1 = r1.Next(12);
        return _title = titles[t1];
    }
    public string GetAuthor()
    {
        Random r1 = new Random();
        int a1 = r1.Next(9);
        return _author = authors[a1];
    }
    public string GetLength()
    {
        Random r1 = new Random();
        int l1 = r1.Next(14);
        return _length = lengths[l1];
    }
    public void Report()
    {
        Console.WriteLine($"\nVideo:\n{_title} ({_length}), from {_author}\nComments:");
        foreach (Comments comments in _comments)
        {
            comments.Display();
        }
        // return "";
    }
}