namespace MyFirstApplication;

public enum FavoriteMovies{Brave, BigHeroSix, HarryPotter, HowlsMovingCastle, Ponyo };
internal class Exercise15
{
    public string TaskOneEnums(FavoriteMovies movie)
    {
        string message = movie switch
        {
            FavoriteMovies.Brave => $"My favorite movie is {FavoriteMovies.Brave}",
            FavoriteMovies.BigHeroSix => $"My favorite movie is {FavoriteMovies.BigHeroSix}",
            FavoriteMovies.HarryPotter => $"My favorite movie is {FavoriteMovies.HarryPotter}",
            FavoriteMovies.HowlsMovingCastle => $"My favorite movie is {FavoriteMovies.HowlsMovingCastle}",
            _ => $"My favorite movie is {FavoriteMovies.Ponyo}"

        };
        return message;
    }

    public (int able, string beta) TaskTwo(FavoriteMovies movies)
    {
        int value = (int)movies;
        string value2 = movies.ToString();

        return (value, value2);

    }

}
