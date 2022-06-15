using System.ComponentModel.DataAnnotations;
using Test_Project.Data.Enums;

namespace Test_Project.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
