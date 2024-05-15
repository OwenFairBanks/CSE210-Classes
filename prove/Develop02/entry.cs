public class Entry
{
    public string _entryPrompt;
    public string _entryDate;
    public string _entryTime;
    public string _entryText;
    public void Display() {
        Console.WriteLine($"\nDate: {_entryDate} - Time: {_entryTime}\nPrompt: {_entryPrompt}\n{_entryText}");
    }
}