using System.ComponentModel.DataAnnotations;

namespace Test_Project.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public virtual List<Movie> Movies { get; set; }
    }
}
