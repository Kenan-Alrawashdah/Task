using Persistence.Entities.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class TaskEntity: BaseEntity
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(1024, MinimumLength = 3)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public StatusTask Status { get; set; }
        public decimal ACtualCost { get; set; }
        public decimal TotalBudget { get; set; }

        // self join
        public int? ParentId { get; set; }
        public TaskEntity Parent { get; set; }
        public  ICollection<TaskEntity> Children { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public TaskEntity()
        {
            Employees = new HashSet<Employee>();
            Children = new HashSet<TaskEntity>();
        }

    }
}
