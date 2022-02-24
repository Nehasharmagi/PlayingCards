using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlayingCards.Models;

namespace PlayingCards.Data
{
    public class PlayingCardsContext : DbContext
    {
        public PlayingCardsContext (DbContextOptions<PlayingCardsContext> options)
            : base(options)
        {
        }

        public DbSet<PlayingCards.Models.PlayingCard> PlayingCard { get; set; }
    }
}
