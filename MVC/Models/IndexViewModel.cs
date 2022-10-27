namespace MVC.Models
{
    public class IndexViewModel
    {
        public ICollection<TaskModel>? Tasks { get; set; }

        public TaskModel? Task { get; set; }

        public ICollection<EmployeeModel>? Employees { get; set; }

        public ICollection<string>? Status { get; set; }
    }
}
