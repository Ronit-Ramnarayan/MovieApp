namespace MovieApp.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public Actor_Movie(int movieId, Movie movie, int actorId, Actor actor)
        {
            MovieId = movieId;
            Movie = movie;
            ActorId = actorId;
            Actor = actor;
        }
    }
}
