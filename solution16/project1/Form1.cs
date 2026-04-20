using MiniNetflixWin;

namespace project1
{
    public partial class Form1 : Form
    {
        User user;
        Movie movie;
        public Form1()
        {
            InitializeComponent();
            user = new User("Sheika");
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User not initialized");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Enter movie title");
                return;
            }

            movie = new Movie(txtTitle.Text, txtGenre.Text, (int)numRating.Value);

            string result = user.WatchMovie(movie);

            lstMovies.Items.Add(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate = (int)numRating.Value;

            if (movie == null)
            {
                MessageBox.Show("Watch a movie first!");
                return;
            }

            if (rate >= 1 && rate <= 10)
            {
                user.RateMovie(movie, rate);
                lstMovies.Items.Add($"{movie.Title} rated {rate}/10");
            }
            else
            {
                MessageBox.Show("Rating must be between 1 and 10");
            }
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstMovies.Items.Clear();

            foreach (var item in user.GetWatchHistory())
            {
                lstMovies.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
