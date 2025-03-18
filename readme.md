
# Movie Watchlist App - Technical Documentation

## Overview
Movie Watchlist App is a console and Windows Forms-based application that allows users to manage a list of movies. Users can add, search, edit, and delete movies in their watchlist.

## Project Structure
The project consists of multiple files:
- **Program1.cs** (Console application entry point)
- **MovieWatchlist.Core.cs** (Business logic for managing movies)
- **Form1.cs** (Windows Forms UI logic)
- **Form1.Designer.cs** (Auto-generated Windows Forms UI layout)

---

## Program1.cs
**Namespace:** `MovieWatchlist.ConsoleApp`
### Functions:
- `Main()`: Entry point of the console app, runs the main menu loop.
- `DisplayMenu()`: Prints the main menu options to the console.
- `AddMovieMenu()`: Provides a menu for adding movies.
- `AddMovie()`: Takes user input and adds a new movie to the watchlist.
- `DisplayMoviesMenu()`: Displays all movies in the watchlist.
- `DisplayMovies()`: Iterates through the movie list and prints each entry.
- `SearchMovieMenu()`: Provides a menu for searching movies.
- `SearchMovie()`: Searches for a movie by title and displays the result.
- `DeleteMovieMenu()`: Provides a menu for deleting a movie.
- `DeleteMovie()`: Deletes a movie from the watchlist based on user input.
- `EditMovieMenu()`: Provides a menu for editing a movie.
- `EditMovie()`: Edits an existing movie with new details.
- `DisplaySuccess(string message)`: Displays a success message in green text.
- `DisplayError(string message)`: Displays an error message in red text.
- `DisplayExitMessage()`: Shows an exit message when quitting the app.
- `PauseForEffect()`: Pauses execution until the user presses a key.

---

## MovieWatchlist.Core.cs
**Namespace:** `MovieWatchList.Core`
### Classes:
- `Movie`: Represents a movie with properties:
  - `Title`: Movie title
  - `Genre`: Movie genre
  - `Year`: Release year
  - `Director`: Director name
- `MovieWatchlistManager`: Manages a collection of movies.
### Functions:
- `AddMovie(Movie movie)`: Adds a movie to the list.
- `GetAllMovies()`: Returns all movies in the watchlist.
- `SearchMovie(string title)`: Searches for a movie by title.
- `DeleteMovie(string title)`: Deletes a movie from the list.
- `EditMovie(string title, Movie updatedMovie)`: Edits an existing movie.

---

## Form1.cs
**Namespace:** `MovieWatchlistApp`
### Functions:
- `Form1()`: Initializes the Windows Form.
- `btnAddMovie_Click(object sender, EventArgs e)`: Handles adding a new movie.
- `btnSearchMovie_Click(object sender, EventArgs e)`: Handles searching for a movie.
- `btnEditMovie_Click(object sender, EventArgs e)`: Handles editing an existing movie.
- `btnDeleteMovie_Click(object sender, EventArgs e)`: Handles deleting a movie.
- `btnSaveMovie_Click(object sender, EventArgs e)`: Saves the edited movie.
- `btnBackToMenu_Click(object sender, EventArgs e)`: Navigates back to the main menu.
- `RefreshMovieList()`: Updates the DataGridView with the latest movie list.

---

## Form1.Designer.cs
**Namespace:** `MovieWatchlistApp`
### Purpose:
- Auto-generated file that defines UI components:
  - `dgvMovies`: DataGridView to display movies
  - `btnAddMovie`: Button to add a movie
  - `btnSearchMovie`: Button to search for a movie
  - `btnEditMovie`: Button to edit a movie
  - `btnDeleteMovie`: Button to delete a movie
  - `btnSaveMovie`: Button to save an edited movie
  - `btnBackToMenu`: Button to return to the main menu
  - `txtTitle, txtGenre, txtYear, txtDirector`: Text fields for movie details
- Contains layout configurations and event bindings.

---

## Summary
This documentation provides an overview of the **Movie Watchlist App**, explaining its components, structure, and function definitions. The app enables users to manage a personal watchlist through a console-based UI and a Windows Forms UI. 🚀

