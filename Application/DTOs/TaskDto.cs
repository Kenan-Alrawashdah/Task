using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TaskDto
    {

        public int? ID { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public decimal? ActualCost { get; set; }
        public decimal? TotalBudget { get; set; }
        public int? ParentId { get; set; }
        public ICollection<TaskDto> Children { get; set; }

        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
