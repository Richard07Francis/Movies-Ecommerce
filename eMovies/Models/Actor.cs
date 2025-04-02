using eMovies.Data.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace eMovies.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image")]
        [Required(ErrorMessage = "Please upload an image.")]
        public string ProfilePictureURL { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter the actor's full name.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 50 characters.")]
        public string FullName { get; set; }
        [DisplayName("Biography")]
        [Required(ErrorMessage = "Please enter the actor's biography.")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; } = new List<Actor_Movie>();
    }
}
