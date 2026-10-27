using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of movies: ");
        int n = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Number;Name;Year;Genre(1-5);Views;Likes");

            string[] data = Console.ReadLine().Split(';');

            movies[i] = new Movie();

            movies[i].Number = int.Parse(data[0]);
            movies[i].Name = data[1];
            movies[i].Year = int.Parse(data[2]);

            int genreNumber = int.Parse(data[3]);

            switch (genreNumber)
            {
                case 1:
                    movies[i].MovieGenre = Genre.Action;
                    break;
                case 2:
                    movies[i].MovieGenre = Genre.Comedy;
                    break;
                case 3:
                    movies[i].MovieGenre = Genre.Drama;
                    break;
                case 4:
                    movies[i].MovieGenre = Genre.Horror;
                    break;
                case 5:
                    movies[i].MovieGenre = Genre.Adventure;
                    break;
                default:
                    movies[i].MovieGenre = Genre.Action;
                    break;
            }

            movies[i].Views = int.Parse(data[4]);
            movies[i].Likes = int.Parse(data[5]);
        }

        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(movies[i].ToString());
        }
    }
}