using MovieWatchList.Core;

namespace MovieWatchlist.ConsoleApp
{
    class Program
    {
        private static MovieWatchlistManager watchlistManager = new MovieWatchlistManager();

        static void Main()
        {
            Console.Title = "Movie Watchlist App";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            bool isRunning = true;

            while (isRunning)
            {
                DisplayMenu();

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddMovieMenu();
                        break;
                    case "2":
                        DisplayMoviesMenu();
                        break;
                    case "3":
                        SearchMovieMenu();
                        break;
                    case "4":
                        DeleteMovieMenu();
                        break;
                    case "5":
                        EditMovieMenu();
                        break;
                    case "6":
                        isRunning = false;
                        DisplayExitMessage();
                        break;
                    default:
                        DisplayError("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("WELCOME TO MOVIE WATCHLIST");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Display All Movies");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Delete Movie");
            Console.WriteLine("5. Edit Movie");
            Console.WriteLine("6. Exit");
            Console.WriteLine(new string('=', 30));
        }

        static void AddMovieMenu()
        {
            bool backToMain = false;
            while (!backToMain)
            {
                Console.Clear();
                Console.WriteLine("\n--- Add a New Movie ---");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Back to Main Menu");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddMovie();
                        break;
                    case "2":
                        backToMain = true;
                        break;
                    default:
                        DisplayError("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddMovie()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Release Year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                DisplayError("Please enter a valid year: ");
            }

            Console.Write("Director: ");
            string director = Console.ReadLine();

            watchlistManager.AddMovie(new Movie(title, genre, year, director));
            DisplaySuccess($"Movie '{title}' has been added to the watchlist.");
            PauseForEffect();
        }

        static void DisplayMoviesMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- Movie List ---");
            DisplayMovies();
            PauseForEffect();
        }

        static void DisplayMovies()
        {
            foreach (Movie movie in watchlistManager.GetAllMovies())
            {
                Console.WriteLine(movie);
            }
        }

        static void SearchMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- Search Movie ---");
            SearchMovie();
            PauseForEffect();
        }

        static void SearchMovie()
        {
            Console.Write("Enter the title to search: ");
            string title = Console.ReadLine();

            Movie movie = watchlistManager.SearchMovie(title);
            if (movie != null)
            {
                Console.WriteLine(movie);
            }
            else
            {
                DisplayError("Movie not found.");
            }
        }

        static void DeleteMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- Delete Movie ---");
            DeleteMovie();
            PauseForEffect();
        }

        static void DeleteMovie()
        {
            Console.Write("Enter the title to delete: ");
            string title = Console.ReadLine();

            if (watchlistManager.DeleteMovie(title))
            {
                DisplaySuccess($"Movie '{title}' has been deleted from the watchlist.");
            }
            else
            {
                DisplayError("Movie not found.");
            }
        }

        static void EditMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- Edit Movie ---");
            EditMovie();
            PauseForEffect();
        }

        static void EditMovie()
        {
            Console.Write("Enter the title to edit: ");
            string title = Console.ReadLine();

            Console.Write("New Title: ");
            string newTitle = Console.ReadLine();

            Console.Write("New Genre: ");
            string newGenre = Console.ReadLine();

            Console.Write("New Year: ");
            int newYear;
            while (!int.TryParse(Console.ReadLine(), out newYear))
            {
                DisplayError("Please enter a valid year: ");
            }

            Console.Write("New Director: ");
            string newDirector = Console.ReadLine();

            Movie updatedMovie = new Movie(newTitle, newGenre, newYear, newDirector);

            if (watchlistManager.EditMovie(title, updatedMovie))
            {
                DisplaySuccess("Movie has been updated.");
            }
            else
            {
                DisplayError("Movie not found.");
            }
        }

        static void DisplaySuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void DisplayExitMessage()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the Movie Watchlist App!");
            Thread.Sleep(1500);
        }

        static void PauseForEffect()
        {
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
