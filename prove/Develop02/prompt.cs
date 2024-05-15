using System.Threading.Channels;

public class Prompts
{
    public int _choice;
    List<string> questions = ["What was the best part of my day?",  //1
    "Who was the most interesting person I interacted with today?", //2
    "How do I see the hand of the Lord in my life today?",          //3
    "What was the strongest emotion I felt today?",                 //4
    "If I had one thing I could do over today, what would it be?",  //5
    "Where have I traveled to today?",                              //6
    "If I could meet a friend today, who would that be?",           //7
    "What did I learn today?",                                      //8
    "Did I strive to keep the Lord's covenant today?",              //9
    "What did I eat for breakfast, lunch, and/or dinner today"];    //10

    public string getquestion()
    {
        string question = "";
        return question = questions[_choice];
    }
    public void Display()
    {
        Console.WriteLine(getquestion());
    }
}
