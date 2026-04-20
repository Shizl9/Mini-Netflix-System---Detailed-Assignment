using System;
using System.Collections.Generic;


namespace MiniNetflixWin
{
    public class User
    {
        public string Name { get; set; }

        private int watchCount;
        public int WatchCount => watchCount;

        private List<string> watchedMovies = new List<string>();
        private List<WatchSession> sessions = new List<WatchSession>();

        public User(string name)
        {
            Name = name;
        }

        public string WatchMovie(Movie movie)
        {
            watchCount++;

            watchedMovies.Add(movie.Title); 

            WatchSession session = new WatchSession(Name, movie.Title);
            sessions.Add(session);

            return $"{Name} is watching {movie.Title}";
        }

        public List<string> GetWatchHistory()
        {
            if (sessions == null)
                return new List<string>();

            List<string> history = new List<string>();

            foreach (var s in sessions)
            {
                history.Add($"{s.UserName} watched {s.MovieTitle}");
            }

            return history;
        }

        public string RateMovie(Movie movie, int rate)
        {
            if (!watchedMovies.Contains(movie.Title))
                return "Watch movie first!";

            if (rate >= 1 && rate <= 10)
            {
                movie.Rating = rate;
                return $"{Name} rated {movie.Title} = {rate}";
            }

            return "Invalid rating";
        }
    }
}
