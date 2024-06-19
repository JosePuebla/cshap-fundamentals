namespace MyFirstApplication;

internal class Exercise6
{
    // Delegate
    public delegate void TryOn(string arg1);

    // private class variables
    private int _showSize;
    private string _shoeType;

    // properties
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    // Constructor
    public Exercise6(int showSize, string shoeType)
    {
        _showSize = showSize;
        _shoeType = shoeType;
    }

    public void TaskThree(string arg2)
    {
       Console.WriteLine(arg2);
    }
}
