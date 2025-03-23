using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform.Models.DTO
{
    public class Achivments_DTO_get
    {
        public string? title { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public string? imageUrl { get; set; }
    }
    public class Achivments_DTO_add
    {
        public string? title { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public IFormFile? image { get; set; }
    }
}
