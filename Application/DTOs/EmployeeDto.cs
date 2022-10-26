using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class EmployeeDto
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
