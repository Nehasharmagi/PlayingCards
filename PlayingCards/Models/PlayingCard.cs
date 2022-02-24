using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PlayingCards.Models
{
    public class PlayingCard
    {
        public int Id { get; set; }
        public string? NameOfCard { get; set; }

       
        public DateTime ReleaseDate { get; set; }
        public string? TypeOfCard { get; set; }
        public decimal Price { get; set; }
        public int ? Rating { get; set; }

        internal static object CreateBuilder(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
