namespace MyFirstApplication;

/*
 A struct is a value type while a class s a reference type.
You should use a struct for small objects that need to be 
memory dependent. 
 */
internal struct Location // renamed location to match slide
{

    private double _longitude, _latitude;

    public double Latitude
    {
        get { return _latitude; }
        set { _latitude = value;  }
    }

    public double Longitude
    {
        get { return _longitude; }
        set { _longitude = value; }
    }

    public Location(double longitude, double latitude)
    {
        _longitude = longitude;
        _latitude = latitude;
    }

    // ToString Override
    public override string ToString()
    {
        return $"{_longitude} - {_latitude}";
    }
    
} // end struct


// Read only struct.
public readonly struct Student
{
    private readonly int _id;
    private readonly string _name;

    public int StudentId
    {
        get { return _id; }
        // set { _id = value; }
    }

    public string StudentName
    {
        get { return _name; }
        // set { _name = value; }
    }

    public Student(int studentId, string studentName)
    {
        _id = studentId;
        _name = studentName;
    }

} // end struct
