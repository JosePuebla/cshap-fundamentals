namespace MyFirstApplication;

internal class Boat
{
    private string _boatColor;
    private string _boatBuild;
    private int _boatSizeFeet;
    public string BoatColor 
    {
        get => _boatColor;
        set => _boatColor = value;
    }
    public string BoatBuild
    {
        get => _boatBuild;
        set => _boatBuild = value;
    }
    public int BoatSizeFeet 
    {
        get => _boatSizeFeet;
        set => _boatSizeFeet = value;
    }

    public Boat()
        :this("red", 45)
    {
        MotorOnOff(); 
    }

    public Boat(string boatColor, int boatSizeFeet)
        : this( boatColor, "speedboat", boatSizeFeet)
    { }

    public Boat(string boatColor, string boatBuild, int boatSizeFeet)
    {
        BoatColor = boatColor;
        BoatBuild = boatBuild;
        BoatSizeFeet = boatSizeFeet;
    }

    public void MotorOnOff()
    {
        Console.WriteLine($"The boat's motor is now turned on.");
    }

} // end class

// Derived Class

internal class Sailboat : Boat
{
    private int _sailCount;
    private int _cabinSpaceSQFt;
    public int SailboatCount
    {
        get => _sailCount;
        set => _sailCount = value;
    }
    public int CabinSpaceSQFt
    {
        get => _cabinSpaceSQFt;
        set => _cabinSpaceSQFt = value;
    }

    public Sailboat()
    :this("Red", 65, 3)
    {
        RaiseLowerSails();
    }

    public Sailboat(string boatColor, int boatSizeFeet, int sailCount)
    :this(boatColor, "Sailboat", boatSizeFeet, sailCount, 135)
    { }

    public Sailboat(string boatColor, string boatBuild, int boatSizeFeet, int sailCount, int cabinspaceSQFt)
    :base(boatColor, boatBuild, boatSizeFeet)
    {
        _cabinSpaceSQFt = sailCount;
        _sailCount = sailCount;
    }

    public void RaiseLowerSails()
    {
        Console.WriteLine("Sails have been lowered");
    }
}
