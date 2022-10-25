using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Employee: BaseEntity
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string? LastName { get; set; }

        public string? ImageUrl { get; set; }
        public ICollection<TaskEntity> TasksEntity { get; set; }
        

        public Employee()
        {
            TasksEntity = new HashSet<TaskEntity>();
        }
    }
}
