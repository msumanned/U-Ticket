using U_Ticket.Data.Emun;
using U_Ticket.Models;

namespace U_Ticket.Data
{
    public class AppDbInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo = "https://images/cinema-logo/Bonicon-Copy.png",
                            Description= "Description of cinema1",
                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            Logo = "https://images/cinema-logo/Bonicon-Copy.png",
                            Description="Description of Cinema 1",
                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            Logo = "https://images/cinema-logo/Bonicon-Copy.png",
                            Description="Description of Cinema 1",
                        },
                        new Cinema()
                        {
                            Name="Cinema 4",
                            Logo = "https://images/cinema-logo/Bonicon-Copy.png",
                            Description="Description of Cinema 1",
                        },
                     });
                    context.SaveChanges();
                    
                }
                //ACtors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePicURL="",
                            FullName="Actor 1",
                            Bio="Bio of actor1"
                        },
                        new Actor()
                        {
                            ProfilePicURL="",
                            FullName="Actor 1",
                            Bio="Bio of actor1"
                        },
                        new Actor()
                        {
                            ProfilePicURL="",
                            FullName="Actor 1",
                            Bio="Bio of actor1"
                        },

                    });
                    context.SaveChanges();
 
                }
                //Produces
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePicURL="",
                            FullName="Producer 1",
                            Bio="This is Bio of Producer1"
                        },
                        new Producer()
                        {
                            ProfilePicURL="",
                            FullName="Producer 1",
                            Bio="This is Bio of Producer1"
                        },
                        new Producer()
                        {
                            ProfilePicURL="",
                            FullName="Producer 1",
                            Bio="This is Bio of Producer1"
                        },
                    });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName="",
                            Descriotion="",
                            Price=12,
                            ImageURL="",
                            StartDate= DateTime.Now.AddDays(3),
                            EndDate= DateTime.Now.AddDays(10),
                            CinemaId= 1,
                            ProducerId= 1,
                            MovieCategory= MovieCategory.Action 
                        },
                        new Movie()
                        {
                            MovieName="",
                            Descriotion="",
                            Price=120,
                            ImageURL="",
                            StartDate= DateTime.Now.AddDays(3),
                            EndDate= DateTime.Now.AddDays(10),
                            CinemaId= 2,
                            ProducerId= 3,
                            MovieCategory= MovieCategory.Action 
                        },
                        new Movie()
                        {
                            MovieName="",
                            Descriotion="",
                            Price=1200,
                            ImageURL="",
                            StartDate= DateTime.Now.AddDays(3),
                            EndDate= DateTime.Now.AddDays(10),
                            CinemaId= 1,
                            ProducerId= 2,
                            MovieCategory= MovieCategory.Action 
                        },
                    });
                    
                    context.SaveChanges();
                }
                //Movie_Actor
                if (!context.Movies_Actors.Any())
                {
                    context.Movies_Actors.AddRange(new List<Movie_Actor>()
                    {
                        new Movie_Actor()
                        {
                            ActorId= 1,
                            MovieId= 2
                        },
                        new Movie_Actor()
                        {
                            ActorId= 2,
                            MovieId= 2
                        },
                        new Movie_Actor()
                        {
                            ActorId= 3,
                            MovieId= 2
                        },

                    });
                    context.SaveChanges();
                }





            }
        }
    }
}
