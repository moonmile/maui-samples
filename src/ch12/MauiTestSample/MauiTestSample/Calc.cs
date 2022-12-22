namespace MauiTestSample;

public class Calc
{
    public int Add( int x, int y )
    {
        return x + y;
    }
    public string Add( string a, string b )
    {
        return a + " and " + b;
    }
    private int _count = 0;
    public int Count => _count;
    public void CountUp()
    {
        _count++;
    }
}
