using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform.Models
{
    public class Achivments
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?title {  get; set; }
        [Required]
        public string ?description { get; set; }
        [Required]
        public string ?imageUrl { get; set; }
    }
}
