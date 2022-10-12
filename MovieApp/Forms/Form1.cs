using MoviesApp.Forms;
using MoviesApp.Models;
using MoviesApp.UserControls;
using System.Net.Http;
using System.Text.Json;

namespace MoviesApp
{
    public partial class Form1 : Form
    {
        const string _apiKey = "a65caa9c";
        const string _url = $"http://www.omdbapi.com/";
        string? _search;
        public List<string> MovieNames = new()
        {
            "Avengers",
            "Spider-Man",
            "Avatar",
            "Iron+Man"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in MovieNames)
            {
                _search = $"{_url}?t={item}&apikey={_apiKey}";

                using HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(_search);
                var movie = JsonSerializer.Deserialize<Movie>(response);

                UCFilmPoster uCFilmPoster = new UCFilmPoster(movie);
                flowLayoutPanel1.Controls.Add(uCFilmPoster);
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using HttpClient httpClient = new HttpClient();
            _search = $"{_url}?t={textBox1.Text}&apikey={_apiKey}";
            var response = await httpClient.GetStringAsync(_search);
            var movie = JsonSerializer.Deserialize<Movie>(response);

            Poster poster = new(movie);
            poster.Show();
            UCFilmPoster uCFilmPoster = new UCFilmPoster(movie);
            flowLayoutPanel1.Controls.Add(uCFilmPoster);
        }
    }
}