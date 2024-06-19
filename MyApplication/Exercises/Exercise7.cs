namespace MyFirstApplication;

internal struct Exercise7
{
    // private variables 
    private int _id;
    private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Exercise7(int arg1, string arg2)
    {
        _id = arg1;
        _name = arg2;
    }

    // Record for Task Two
    internal record Boat(string boatColor, string boatName)
    {
        public void TurnMotorOn()
        {
            Console.WriteLine("Motor has been turned on");
        }
    }

}
