namespace MyFirstApplication;

internal class Exercise16
{
    public void TaskOne()
    {
        List<string> horse = new List<string>();
        Horse taskHorse  = new Horse();
        horse.Add(taskHorse.HorseSpecies);
        horse.Add(taskHorse.ManeStyle);
        horse.Add(taskHorse.HorseJob);
        // task called for 2 but i hope it's alright i chose to do three

        foreach (string item in horse)
        {
            Console.WriteLine(item);
        } // end method

    }

    public void TaskTwo()
    {
        // Brave, BigHeroSix, HarryPotter, HowlsMovingCastle, Ponyo
        Dictionary<int, string> favoriteMovies = new Dictionary<int, string>();
        favoriteMovies.Add(10, "Brave");
        favoriteMovies.Add(20, "Big Hero Six");
        favoriteMovies.Add(30, "Harry Potter");
        favoriteMovies.Add(40, "Howls Moving Castle");
        favoriteMovies.Add(50, "Ponyo");

        foreach (KeyValuePair<int, string> item in favoriteMovies)
        {
            Console.WriteLine($"Key: {item.Key}, Movie: {item.Value}");
        }
    }

}
