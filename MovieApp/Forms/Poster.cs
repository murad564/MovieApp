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

namespace MoviesApp.Forms
{
    public partial class Poster : Form
    {
        public Poster(Movie movie)
        {
            InitializeComponent();
            Text = movie.Title;
            pictureBox1.Load(movie.Poster);
            textBox1.Text = movie.Plot;
            label1.Text = movie.Genre;
            label2.Text = movie.Title;
            label3.Text = movie.imdbRating;
            label4.Text = movie.Actors;
        }
    }
}