using MoviesApp.Forms;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp.UserControls
{
    public partial class UCFilmPoster : UserControl
    {
        Movie Movie { get; set; }
        public UCFilmPoster(Movie movie)
        {
            InitializeComponent();
            Movie = movie;
            pbox_poster.Load(Movie.Poster);
            lbl_title.Text = Movie.Title;
            lbl_year.Text = Movie.Year;
        }

        private void pbox_poster_Click(object sender, EventArgs e)
        {
            Poster poster = new(Movie);
            poster.ShowDialog();
        }
    }
}