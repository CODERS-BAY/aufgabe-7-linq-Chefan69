

namespace LinqExercise;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Alle Filme: ");
        FilmOperations filmOperations = new FilmOperations();
        var films = filmOperations.GetAllMovies();
        foreach (Film film in films)
        {
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Filme von Peter Jackson:");
        var filmsByDirector = filmOperations.GetMoviesByDirector("Peter Jackson");
        foreach (Film film in filmsByDirector)
        {
            Console.WriteLine(film.Title);
        }

        Console.WriteLine();
        Console.WriteLine("Filme von 1998:");
        var filmsByYear = filmOperations.GetMoviesByYear(1998);
        foreach(Film film in filmsByYear)
        {
            Console.WriteLine(film.Title + ", Erscheinungsjahr: " + film.ReleaseYear);
        }

        Console.WriteLine();
        Console.WriteLine("Filme mit einer Bewertung zwischen 9.0 und 9.9");
        var filmsByRatingRange = filmOperations.GetMoviesByRatingRange(9.0, 9.9);
        foreach(Film film in filmsByRatingRange)
        {
            Console.WriteLine(film.Title + ", Rating: " + film.Rating);

        }

        Console.WriteLine();
        Console.WriteLine("Die 3 besten bewertesten Filme: ");
        var filmsByRatingSortedLimited = filmOperations.GetMoviesByRatingSortedLimited(3);
        foreach(Film film in filmsByRatingSortedLimited)
        {
            Console.WriteLine(film.Title + ", Rating: " + film.Rating);
        }








    }


}




