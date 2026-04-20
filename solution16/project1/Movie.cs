using System;

namespace MiniNetflixWin
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 10)
                    rating = value;
                else
                    throw new Exception("Rating must be between 1 and 10");
            }
        }

        public Movie(string title, string genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }
}
