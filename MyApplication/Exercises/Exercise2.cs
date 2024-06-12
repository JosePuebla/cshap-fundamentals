

namespace MyFirstApplication;

internal class Exercise2
{
    string lab = " EXERCISE two Lab ";
    /*
     d.Length()e.IndexOf(‘C’)
     */
    public void TaskOne()
    {
        Console.WriteLine(lab.Trim()); //works
        Console.WriteLine(lab.ToLower()); // works
        Console.WriteLine(lab.Contains("tow")); // works
        Console.WriteLine(lab.Length); // works 
        Console.WriteLine(lab.IndexOf('C'));
    }

    public void TaskTwo()
    {
        char pilcrew = '\u00B6';
        Console.WriteLine(pilcrew);
    }

    public void TaskThree()
    {
        string jackAndJill = "Jack and Jill \nwent up the hill \nto fetch a pail of water. \nJack fell down and broke his crown \nAnd Jill came tumbling after.";
        Console.WriteLine(jackAndJill);

    }
}
