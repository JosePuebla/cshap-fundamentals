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

}
