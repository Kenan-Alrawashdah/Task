using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class EmployeeModel
    {
        public int? ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(255, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(255, MinimumLength = 3)]
        public string? LastName { get; set; }

        public IFormFile? Photo { get; set; }
        public string? PhotoName { get; set; }

        [Display(Name = "Create At")]
        public DateTime CreateAt { get; set; }

    }
}
