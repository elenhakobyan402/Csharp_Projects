using System;

public enum Genre
{
    Action = 1,
    Comedy,
    Drama,
    Horror,
    Adventure
}

public class Movie
{
    public int Number;
    public string Name;
    public int Year;
    public Genre MovieGenre;
    public int Views;
    public int Likes;

    public double GetRating()
    {
        if (Views == 0)
            return 0;

        return Math.Sqrt((double)Likes * Likes / Views);
    }

    public override string ToString()
    {
        string year = "(" + Year + ")";
        string genre = MovieGenre.ToString();

        return string.Format("{0,4}{1,-15}{2,-8}{3,-12}{4,8:F3}",
            Number, Name, year, genre, GetRating());
    }
}