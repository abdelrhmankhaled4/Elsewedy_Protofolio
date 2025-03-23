using System.ComponentModel.DataAnnotations;

namespace Elsewedy_Platform.Models
{
    public class Porject_Information
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string ?fName { get; set; }
        [Required]
        public string ?lname { get; set; }
        [Required]
        public string ?description { get; set; }
        [Required]
        public string ?company_name { get; set; }
        [Required]
        public string ?email { get; set; }
        public string ?massege { get; set; }
        [Required]
        public string? status { get; set; }
        [Required]
        public string? phone { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}
