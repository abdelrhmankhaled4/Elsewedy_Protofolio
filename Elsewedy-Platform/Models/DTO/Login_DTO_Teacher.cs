using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models.DTO
{
    public class Login_DTO_Teacher
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? password { get; set; }
    }
}
