using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The genre name is required.")]
        public string? GenreName { get; set; }
    }
}
