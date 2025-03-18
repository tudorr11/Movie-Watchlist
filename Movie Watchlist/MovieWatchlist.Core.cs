using MovieWatchList.Core;

namespace MovieWatchList.Core
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }

        public Movie(string title, string genre, int year, string director)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Director = director;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Genre: {Genre}, Year: {Year}, Director: {Director}";
        }
    }

    public class MovieWatchlistManager
    {
        private readonly List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie SearchMovie(string title)
        {
            return movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public bool DeleteMovie(string title)
        {
            Movie movie = SearchMovie(title);
            if (movie != null)
            {
                movies.Remove(movie);
                return true;
            }
            return false;
        }

        public bool EditMovie(string title, Movie updatedMovie)
        {
            Movie movie = SearchMovie(title);
            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Genre = updatedMovie.Genre;
                movie.Year = updatedMovie.Year;
                movie.Director = updatedMovie.Director;
                return true;
            }
            return false;
        }
    }
}