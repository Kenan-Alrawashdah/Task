using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class TaskModel
    {
        public int? ID { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "The title must between 2 to 255 char")]
        public string Title { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }


        [Display(Name = "Actual Cost")]
        [Range(0, 100000)]
        [DataType(DataType.Currency)]
        public decimal? ActualCost { get; set; }

        [Display(Name = "Total Budget")]
        [Range(0, 200000)]
        [DataType(DataType.Currency)]
        public decimal? TotalBudget { get; set; }
        public int? ParentId { get; set; }
        public ICollection<TaskModel>? Children { get; set; }
        public ICollection<int>? SelectedEmployees { get; set; }
        public ICollection<EmployeeModel>? Employees { get; set; }
    }
}
