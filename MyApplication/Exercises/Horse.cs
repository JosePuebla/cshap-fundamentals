using System.Security.Cryptography.X509Certificates;

namespace MyFirstApplication;

public class Horse
{
    public string ManeStyle {  get; set; }
    public string HorseSpecies {  get; set; }
    public string HorseJob { get; set; }

    public Horse()
        : this("Braided", "Pony")
    {
        RunWalk();
    }

    public Horse(string maneStyle, string horseSpecies)
        : this(maneStyle, horseSpecies, "show horse")
    { }

    public Horse(string maneStyle, string horseSpecies, string horseJob)
    {
        ManeStyle = maneStyle;
        HorseSpecies = horseSpecies;
        HorseJob = horseJob;
    }

    public void RunWalk()
    {
        Console.WriteLine("Horse is now walking");
    }
}

// Derived class 
public class Pony : Horse
{
    public int PonySizeHands {  get; set; }
    public string Gender { get; set; }

    public Pony() 
    :this("Short", "Show Pony","Male")
    {
        EatSleep(); 
    }

    public Pony(string maneStyle, string horseJob, string gender)
    :this(maneStyle, "Pony", horseJob, 11, gender)
    { }

    public Pony(string maneStyle, string horseSpecies, string horseJob, int ponySizeHands, string gender)
    :base(maneStyle, horseSpecies, horseJob)
    {
        PonySizeHands = ponySizeHands;
        Gender = gender;
    }

    public void EatSleep()
    {
        Console.WriteLine("The Pony is ready for bed");
    }

    //public pony eat/sleep
}