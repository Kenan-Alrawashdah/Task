using Application.DTOs;
using Application.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Persistence.Entities.Constant;

namespace MVC.Controllers
{
    public class TasksController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ITaskEntityService _taskEntityService;
        public TasksController(IEmployeeService employeeService, ITaskEntityService taskEntityService)
        {
            _employeeService = employeeService;
            _taskEntityService = taskEntityService;
        }
        public ActionResult Index()
        {
            var employees = _employeeService.GetAll().Select(emp => new EmployeeModel { 
                ID = emp.ID, FirstName = emp.FirstName, LastName = emp.LastName 
            }).ToList();

            var status = Enum.GetValues(typeof(StatusTask)).Cast<StatusTask>().Select(sta => sta.ToString()).ToList();

            var task = _taskEntityService.GetAll().Select(task => new TaskModel
            {   
                ID = task.ID,
                Title = task.Title,
                Description = task.Description,
                ActualCost = task.ActualCost,
                TotalBudget = task.TotalBudget,
                StartDate = task.StartDate,
                EndDate = task.EndDate,
                ParentId = task.ParentId,
                Status = task.Status,
                Employees = task.Employees.Select(emp => new EmployeeModel { ID = emp.ID, PhotoName = emp.ImageUrl, FirstName = emp.FirstName, LastName = emp.LastName }).ToList(),
                Children = task.Children.Select(sub => new TaskModel
                {  
                    ID  = sub.ID,
                    Title = sub.Title,
                    Description = sub.Description,
                    ActualCost = sub.ActualCost,
                    TotalBudget = sub.TotalBudget,
                    StartDate = sub.StartDate,
                    EndDate = sub.EndDate,
                    ParentId = sub.ParentId,
                    Status = sub.Status,
                    Employees = sub.Employees.Select(emp => new EmployeeModel { ID = emp.ID, PhotoName = emp.ImageUrl, FirstName = emp.FirstName, LastName= emp.LastName }).ToList(),
                }).ToList(),
            }).ToList();
             
            var model = new IndexViewModel
            {
                Employees = employees,
                Status = status,
                Task = new TaskModel(),
                Tasks = task,
            };

            return View(model);
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IndexViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employees = model.Task?.SelectedEmployees?.Select(id => new EmployeeDto { ID = id }).ToList();
                    var task = new TaskDto
                    {
                        Title = model.Task.Title,
                        Description = model.Task.Description,
                        ActualCost = model.Task.ActualCost,
                        TotalBudget = model.Task.TotalBudget,
                        StartDate = model.Task.StartDate,
                        EndDate = model.Task.EndDate,
                        ParentId = model.Task.ParentId,
                        Status = model.Task.Status,
                        Employees = employees,

                    };

                    _taskEntityService.Add(task);

                    return Json(new { success = true, message = "Sucssecful", status = 200 });
                }
                else
                {
                    return Json(new { success = false, message = "test error", status = 400 });
                }
            }
            catch
            {
                return  Json(new { success = false, message = "test error", status = 500 });
            }
        }

      
    }
}
