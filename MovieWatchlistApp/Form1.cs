using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MovieWatchList.Core;

namespace MovieWatchlistApp
{
    public partial class Form1 : Form
    {
        private MovieWatchlistManager watchlistManager = new MovieWatchlistManager();
        private Button selectedButton = null;

        public Form1()
        {
            InitializeComponent();
            InitializePlaceholders();
            InitializeEvents();
        }

        private void InitializePlaceholders()
        {
            txtTitle.Text = "Enter title...";
            txtGenre.Text = "Enter genre...";
            txtYear.Text = "Enter year...";
            txtDirector.Text = "Enter director...";

            txtTitle.GotFocus += RemovePlaceholder;
            txtGenre.GotFocus += RemovePlaceholder;
            txtYear.GotFocus += RemovePlaceholder;
            txtDirector.GotFocus += RemovePlaceholder;

            txtTitle.LostFocus += AddPlaceholder;
            txtGenre.LostFocus += AddPlaceholder;
            txtYear.LostFocus += AddPlaceholder;
            txtDirector.LostFocus += AddPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text.StartsWith("Enter "))
            {
                textBox.Text = "";
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtTitle) textBox.Text = "Enter title...";
                if (textBox == txtGenre) textBox.Text = "Enter genre...";
                if (textBox == txtYear) textBox.Text = "Enter year...";
                if (textBox == txtDirector) textBox.Text = "Enter director...";
            }
        }

        private void InitializeEvents()
        {
            btnAddMovie.Click += (s, e) => SetActiveButton(btnAddMovie);
            btnSearchMovie.Click += (s, e) => SearchMovie();
            btnEditMovie.Click += (s, e) => SetActiveButton(btnEditMovie);
            btnDeleteMovie.Click += (s, e) => DeleteMovie();
            btnBackToMenu.Click += (s, e) => ResetSelection();
            btnSaveMovie.Click += (s, e) => SaveMovie();
        }

        private void SetActiveButton(Button button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.Control;
            }
            selectedButton = button;
            selectedButton.BackColor = Color.Gray;
        }

        private void ResetSelection()
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.Control;
                selectedButton = null;
            }
            dgvMovies.ClearSelection();
        }

        private void SaveMovie()
        {
            if (int.TryParse(txtYear.Text, out int year))
            {
                if (selectedButton == btnAddMovie)
                {
                    watchlistManager.AddMovie(new Movie(txtTitle.Text, txtGenre.Text, year, txtDirector.Text));
                }
                else if (selectedButton == btnEditMovie && dgvMovies.SelectedRows.Count > 0)
                {
                    string oldTitle = dgvMovies.SelectedRows[0].Cells[0].Value.ToString();
                    Movie updatedMovie = new Movie(txtTitle.Text, txtGenre.Text, year, txtDirector.Text);
                    watchlistManager.EditMovie(oldTitle, updatedMovie);
                }
                UpdateMovieGrid();
            }
            else
            {
                MessageBox.Show("Invalid year format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMovieGrid()
        {
            dgvMovies.DataSource = null;
            dgvMovies.DataSource = watchlistManager.GetAllMovies();
        }

        private void DeleteMovie()
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                string title = dgvMovies.SelectedRows[0].Cells[0].Value.ToString();
                if (watchlistManager.DeleteMovie(title))
                {
                    UpdateMovieGrid();
                }
                else
                {
                    MessageBox.Show("Movie not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchMovie()
        {
            string query = txtTitle.Text;
            var filteredMovies = watchlistManager.GetAllMovies()
                .Where(m => m.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            dgvMovies.DataSource = null;
            dgvMovies.DataSource = filteredMovies;
        }
    }
}
