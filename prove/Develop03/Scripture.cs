public class Scripture
{
    private string _scripture;

    public Scripture(int num)
    {
        if ( num == 1 )
        {
            _scripture = "Trust in the Lord with all thine heart and lean" +
            " not unto thine own understanding; in all thy ways acknowledge" +
            " him, and he shall direct thy paths.";
        }
        if ( num == 2)
        {
        _scripture = "O all ye that are pure in heart, lift up your heads and" +
        " receive the pleasing word of God, and feast upon his love; for ye" +
        " may, if your minds are firm, forever.";
        }
        if ( num == 3 )
        {
            _scripture = "Verily, Verily, I say unto you, ye must watch and" +
            " pray always, lest ye be tempted by the devil, and ye be led" +
            " away captive by him.";
        }
        if ( num == 4 )
        {
            _scripture = "Now I say, that the heir, as long as he is a child," +
            " differeth nothing from a servant, though he be lord of all;" +
            " But is under tutors and governors until the time appoint of" +
            " the father.";
        }
        if ( num == 5 )
        {
            _scripture = "Judge not, that ye be not judged; For with what" +
            " judgement ye judge, ye shall be judged: and with what measure" +
            " ye mete, it shall be measured to you again.";
        }
    }

    public string Get_Scripture()
    {
        return _scripture;
    }
}