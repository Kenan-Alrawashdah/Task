using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class TaskModel
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(255, MinimumLength = 2)]
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Status { get; set; }
        public decimal? ACtualCost { get; set; }
        public decimal? TotalBudget { get; set; }
        public int? ParentId { get; set; }
        public ICollection<TaskModel> Children { get; set; }

        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
