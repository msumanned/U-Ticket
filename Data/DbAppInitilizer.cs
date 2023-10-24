using U_Ticket.Data.Emun;
using U_Ticket.Models;

namespace U_Ticket.Data
{
    public class DbAppInitilizer
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
                            Description="Description of Cinema 1",
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
                            Bio="Bio of actor1",
                        },
                        new Actor()
                        {
                            ProfilePicURL="",
                            FullName="Actor 1",
                            Bio="Bio of actor1",
                        },
                        new Actor()
                        {
                            ProfilePicURL="",
                            FullName="Actor 1",
                            Bio="Bio of actor1",
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
                            Bio="This is Bio of Producer1",
                        },
                        new Producer()
                        {
                            ProfilePicURL="",
                            FullName="Producer 1",
                            Bio="This is Bio of Producer1",
                        },
                        new Producer()
                        {
                            ProfilePicURL="",
                            FullName="Producer 1",
                            Bio="This is Bio of Producer1",
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
                            MovieCategory= MovieCategory.Action , 
                        },
                    });
                    
                    context.SaveChanges();
                }
                //Movie_Actor
                if (!context.Movies_Actors.Any())
                {
                    
                }





            }
        }
    }
}
