﻿using System.ComponentModel.DataAnnotations;

namespace Test_Project.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public virtual List<Movie> Movies { get; set; }
    }
}
