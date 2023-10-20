using Microsoft.EntityFrameworkCore;
using U_Ticket.Models;

namespace U_Ticket.Data.Emun
{
    public class AppDbContext : DbContext
    {
        private object am;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie_Actor>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId

            });
            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.Movie).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.Actor).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies {  get; set; }
        public DbSet<Movie_Actor> Movies_Actors { get; set; }  
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
