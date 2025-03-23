using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform2.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Required]
        public string ?password { get; set; }
       
    }
}
