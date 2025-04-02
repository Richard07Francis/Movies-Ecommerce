using eMovies.Data.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eMovies.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image")]
        [Required(ErrorMessage = "Please upload a profile picture.")]
        public string ProfilePictureURL { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter the producer's full name.")]
        public string FullName { get; set; }
        [DisplayName("Biography")]
        [Required(ErrorMessage = "Please enter a biography.")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
