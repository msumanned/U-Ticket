using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using U_Ticket.Data.Emun;

namespace U_Ticket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string MovieName { get; set; }   

        public string Descriotion {  get; set; }
        public double Price { get; set; }

        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Movie_Actor> Movies_Actors { get; set; }

        //cinema
        public int CinemaId {  get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerId {  get; set; }
        [ForeignKey ("ProducerId")]
        public Producer Producer { get; set; }
    }
}
