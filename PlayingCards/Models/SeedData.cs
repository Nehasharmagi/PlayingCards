using PlayingCards.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace PlayingCards.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlayingCardsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlayingCardsContext>>()))
            {
                // Look for any movies.
                if (context.PlayingCard.Any())
                {
                    return;   // DB has been seeded
                }

                context.PlayingCard.AddRange(
                    new PlayingCard
                    {
                        Id=1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating=3
                    },

                    new PlayingCard
                    {
                        Id = 2,
                        NameOfCard = "clubs",
                        ReleaseDate = DateTime.Parse("1989--3-12"),
                        TypeOfCard = "queen",
                        Price = 7.99M,
                        Rating = 4
                    },

                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 2

                    },

                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 3
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 2
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 5
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 3
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 3
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 4
                    },
                    new PlayingCard
                    {
                        Id = 1,
                        NameOfCard = "Heart",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        TypeOfCard = "jack",
                        Price = 7.99M,
                        Rating = 2
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}
        
    
        
    

