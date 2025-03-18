namespace MovieWatchlistApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvMovies = new DataGridView();
            btnAddMovie = new Button();
            btnSearchMovie = new Button();
            btnEditMovie = new Button();
            btnDeleteMovie = new Button();
            btnBackToMenu = new Button();
            groupBox1 = new GroupBox();
            btnSaveMovie = new Button();
            txtDirector = new TextBox();
            txtYear = new TextBox();
            txtGenre = new TextBox();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 12);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(520, 393);
            dgvMovies.TabIndex = 0;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(541, 12);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(247, 38);
            btnAddMovie.TabIndex = 1;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            // 
            // btnSearchMovie
            // 
            btnSearchMovie.Location = new Point(541, 56);
            btnSearchMovie.Name = "btnSearchMovie";
            btnSearchMovie.Size = new Size(247, 36);
            btnSearchMovie.TabIndex = 2;
            btnSearchMovie.Text = "Search Movie";
            btnSearchMovie.UseVisualStyleBackColor = true;
            // 
            // btnEditMovie
            // 
            btnEditMovie.Location = new Point(541, 98);
            btnEditMovie.Name = "btnEditMovie";
            btnEditMovie.Size = new Size(247, 34);
            btnEditMovie.TabIndex = 3;
            btnEditMovie.Text = "Edit Movie";
            btnEditMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(541, 138);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(247, 35);
            btnDeleteMovie.TabIndex = 4;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(12, 411);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(517, 36);
            btnBackToMenu.TabIndex = 5;
            btnBackToMenu.Text = "Back To Main Menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveMovie);
            groupBox1.Controls.Add(txtDirector);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtGenre);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(541, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 180);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Details";
            // 
            // btnSaveMovie
            // 
            btnSaveMovie.Location = new Point(2, 138);
            btnSaveMovie.Name = "btnSaveMovie";
            btnSaveMovie.Size = new Size(248, 36);
            btnSaveMovie.TabIndex = 4;
            btnSaveMovie.Text = "Save Movie";
            btnSaveMovie.UseVisualStyleBackColor = true;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(3, 109);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(247, 23);
            txtDirector.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(3, 80);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(247, 23);
            txtYear.TabIndex = 2;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(3, 51);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(247, 23);
            txtGenre.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(3, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(247, 23);
            txtTitle.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnEditMovie);
            Controls.Add(btnSearchMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(dgvMovies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMovies;
        private Button btnAddMovie;
        private Button btnSearchMovie;
        private Button btnEditMovie;
        private Button btnDeleteMovie;
        private Button btnBackToMenu;
        private GroupBox groupBox1;
        private TextBox txtTitle;
        private Button btnSaveMovie;
        private TextBox txtDirector;
        private TextBox txtYear;
        private TextBox txtGenre;
    }
}