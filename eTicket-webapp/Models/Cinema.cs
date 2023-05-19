﻿using System.ComponentModel.DataAnnotations;

namespace eTicket_webapp.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}