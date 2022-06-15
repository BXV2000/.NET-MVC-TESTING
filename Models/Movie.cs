using System.ComponentModel.DataAnnotations;
using Test_Project.Data.Enums;

namespace Test_Project.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public virtual Cinema Cinema { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual List<Actor> Actors { get; set; }
    }
}
