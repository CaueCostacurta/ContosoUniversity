using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class User
    {        
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
