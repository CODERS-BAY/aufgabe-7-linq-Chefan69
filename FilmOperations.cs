using Newtonsoft.Json;

namespace LinqExercise;

public class FilmOperations
{
    /// <returns>eine Liste aller Filme zurück.</returns>
    public List<Film> GetAllMovies()
    {
        StreamReader reader = new(@"C:\Users\Codersbay\Source\Repos\aufgabe-7-linq-Chefan69\films.json");
        string json = reader.ReadToEnd();
        List<Film> films = JsonConvert.DeserializeObject<List<Film>>(json);
        // return a list of all movies
        return films;

        throw new NotImplementedException();
    }

    /// <returns>ein Array von Filmen zurück, die von dem angegebenen Regisseur stammen.</returns>
    public Film[] GetMoviesByDirector(string directorName)
    {
        Film[] films = GetAllMovies().Where(film => film.Director == directorName).ToArray();
        return films;
        throw new NotImplementedException();
    }

    /// <returns>ein Array von Filmen zurück, die im angegebenen Erscheinungsjahr veröffentlicht wurden.</returns>
    public Film[] GetMoviesByYear(int releaseYear)
    {
        Film[] films = GetAllMovies().Where(film => film.ReleaseYear == releaseYear).ToArray();
        return films;
        throw new NotImplementedException();
    }

    /// <returns>ein Array von Filmen zurück, die zwischen der angegebenen Mindest- und Höchstbewertung liegen.</returns>
    public Film[] GetMoviesByRatingRange(double minRating, double maxRating)
    {
        Film[] films = GetAllMovies().Where(film => film.Rating >= minRating && film.Rating <= maxRating).ToArray();
        return films;
        throw new NotImplementedException();
    }

    /// <returns>gibt ein Array mit den best bewerteten Filme zurück, sortiert nach Bewertung. numberOfFilms gibt die
    /// Anzahl der zurückgegeben Filme an.</returns>
    public Film[] GetMoviesByRatingSortedLimited(int numberOfFilms)
    {
        Film[] films = GetAllMovies().OrderByDescending(film => film.Rating).Take(numberOfFilms).ToArray();
        return films;
        throw new NotImplementedException();
    }
}