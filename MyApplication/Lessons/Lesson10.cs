namespace MyFirstApplication;


/*
 Encapsulation is the process of wrapping data and the code into
a single unit.
 */
internal class Lesson10
{
    private string _firstName;
    private string _address;
    protected int zipcode;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    // looks like auto-implemented just means without having to write the whole getset func

    // auto-implemented property with init keyword
    public string LastName { get; init; }

    // auto-implemented property with a default value (so instead of assigning a value when running in program.cs
    // it is already at the default
    public int Id { get; set; } = 1000;

    // property with private set
    public long Phone { get; private set; }

    // Expression bodid member property
    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public int ZipCode
    {
        get => zipcode;
        set => zipcode = value;
    }

    // default constructor
    public Lesson10() { }

    // constructor using *this* with variables
    public Lesson10(string firstName, string lastName, int zipcode)
    {
        _firstName = firstName;
        LastName = lastName;
        this.zipcode = zipcode;
    }



    /*
     This method shohws how you can change a private set property but not a property with init
     */
    private void ShowLastAndPhone()
    {
        // LastName = "Jon";
        Phone = 12345678;
    }


} // end class
