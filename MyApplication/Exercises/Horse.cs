namespace MyFirstApplication;

internal class Horse
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
