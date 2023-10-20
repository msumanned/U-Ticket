using System.ComponentModel.DataAnnotations;

namespace U_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        
        public string Bio { get; set; }

        //relationships
        public List<Movie_Actor> Movies_Actors { get; set; }
    }
}
