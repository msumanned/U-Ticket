namespace U_Ticket.Models
{
    public class Movie_Actor
    {
        internal object am;

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
