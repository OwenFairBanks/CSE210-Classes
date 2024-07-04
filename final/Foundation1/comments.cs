public class Comments
{
    public string _account;
    public string _text;

    List<string> accounts = ["Rita1948","NamelessLost","Normalhuman842",
    "183Bugsnatcher5","ApplEnjoyer","BenjoFox","TF2PyroReal","theRealGamer2873",
    "xXToilet_GamerXx","Khan_Doorman_The_1st","Stanley618Pines","UsernameNotFound"];
    List<string> texts = ["Really cool video! Keep up the hard work!",
    "Big fan of your content!","Didn't enjoy this as I thought I would",
    "Finally, only took 3 months","Really love the doors there, buddy",
    "1:02 I don't know what happened here","Please don't discard us",
    "Bit late to the video, but FIRST!!!@!","If you're looking for good books"+
    ", there's always the Micheal Vay series.","WHO LET BRO COOK?!?",
    "Anything's legal when there's no cops around","Thank's for letting me help out!"];

    public string GetAccount()
    {
        Random r1 = new Random();
        int a1 = r1.Next(9);
        return _account = accounts[a1];
    }
    public string GetText()
    {
        Random r1 = new Random();
        int t1 = r1.Next(12);
        return _text = texts[t1];
    }
    public void Display()
    {
        Console.WriteLine($"{_account}: {_text}");
    }
}