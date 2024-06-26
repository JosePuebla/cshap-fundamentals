﻿namespace MyFirstApplication;

internal class Condo : House 
{
    private string _balcony;
    public string Balcony
    {
        get { return _balcony; } 
        set { _balcony = value; }
    }

    public Condo()
        :this("Second Floor") { }

    public Condo(string balcony)
        : this("concrete", "steel", "Blue", 35, balcony) { }

    public Condo(string foundation, string roofType, string doorColor, 
        int windowSize, string balcony)
        :base(foundation, roofType, doorColor, windowSize)
    {
        _balcony = balcony;
    }


    public override void DoorOpenClose() // did this after making method virtual in House.cs
    {
        Console.WriteLine($"The {DoorColor} door is creaking");
    }
    public void Mainenance()
    {
        Console.WriteLine($"Fixing the {Balcony} on appartment 2. ");
    }

} // end class
