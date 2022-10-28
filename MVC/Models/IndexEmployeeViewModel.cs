namespace MVC.Models
{
    public class IndexEmployeeViewModel
    {
        public ICollection<EmployeeModel>? Employees { get; set; }

        public EmployeeModel? Employee { get; set; }
    }
}
