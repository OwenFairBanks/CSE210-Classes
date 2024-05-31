public class Reference
{
    private string _reference;

    public Reference(int num)
    {
        if ( num == 1 )
        {
            _reference = "Proverbs 3:5-6";
        }
        if ( num == 2 )
        {
            _reference = "Jacob 3:2";
        }
        if ( num == 3 )
        {
            _reference = "3 Nephi 18:15";
        }
        if ( num == 4 )
        {
            _reference = "Galatians 4:1-2";
        }
        if ( num == 5 )
        {
            _reference = "Matthew 7:1-2";
        }
    }

    public string Get_Reference()
    {
        return _reference;
    }
}