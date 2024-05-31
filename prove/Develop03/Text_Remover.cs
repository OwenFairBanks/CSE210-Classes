using System.Security.Cryptography;

public class Remover
{
    private string _removedText;
    private List<int> _amount;

    public Remover(string input, int amount)
    {
        _removedText = input;
        IEnumerable<int> range = Enumerable.Range(0, amount);
        _amount = range.ToList();
    }

    public string Remove_Text()
    {
        string[] text = _removedText.Split(' ');
        List<int> num = _amount;
        int length = num.Count;
        if ( length == 1 )
        {
            num.Add(0);
            num.Add(1);
            length = 3;
        }
        if ( length == 2 )
        {
            num.Add(0);
            length = 3;
        }
        Random rand = new Random();
        if ( length < 1 )
        {
            Environment.Exit(0);
        }
        int r1 = rand.Next(num.Count);
        int chosenNumber1 = num[r1];
        num.Remove(chosenNumber1);
        int r2 = rand.Next(num.Count);
        int chosenNumber2 = num[r2];
        num.Remove(chosenNumber2);
        int r3 = rand.Next(num.Count);
        int chosenNumber3 = num[r3];
        num.Remove(chosenNumber3);
        string word1 = text[chosenNumber1];
        string word2 = text[chosenNumber2];
        string word3 = text[chosenNumber3];
        text[chosenNumber1] = new string('_', word1.Length);
        text[chosenNumber2] = new string('_', word2.Length);
        text[chosenNumber3] = new string('_', word3.Length);
        // Console.WriteLine($"{chosenNumber1}, {chosenNumber2}, {chosenNumber3}");
        // Console.WriteLine(string.Join(", ", _amount));    Used
        string result = string.Join(" ", text);
        _removedText = result;
        _amount = num;
        return result;
    }

}
