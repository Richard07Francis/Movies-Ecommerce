﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eMovies.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Logo")]
        public string Logo { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
