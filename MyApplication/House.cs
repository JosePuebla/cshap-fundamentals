
namespace MyFirstApplication;

/*you change change internal to public but it is not needed
*/
public class House
{
    public string Foundation { get; init; }
    public string RoofType { get; init; }
    public string DoorColor { get; init; }
    public int WindowSize { get; init; }
    // now they can only be set using a constructor in this clas

    public House()
        : this("concrete", "shingles") 
    { }

    public House(string foundation, string roofType) // *this* allows data to be passed into the variables
        : this(foundation, roofType, "Red", 25) // basically the right two are defaults now for doorColor and windowSize if this House() is used
    { }

    public House(string foundation, string roofType, string doorColor, int windowSize)
    {
        Foundation = foundation;
        RoofType = roofType;
        DoorColor = doorColor;
        WindowSize = windowSize;
    }

    public virtual void DoorOpenClose()
    {
        Console.WriteLine($"My {DoorColor} door is open");
    }
}

