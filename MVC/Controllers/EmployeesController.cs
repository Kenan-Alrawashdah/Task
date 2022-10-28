using Application.DTOs;
using Application.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Persistence.Entities;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IWebHostEnvironment _wepHostEnvironment;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService, IWebHostEnvironment wepHostEnvironment)
        {
            _employeeService = employeeService;
            _wepHostEnvironment = wepHostEnvironment;
        }

        public ActionResult Index()
        {
            var employees = _employeeService.GetAll().Select(employee => new EmployeeModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhotoName = employee.ImageUrl,
                CreateAt = employee.CreateAt,
            }).ToList();

            var model = new IndexEmployeeViewModel()
            {
                Employees = employees,
                Employee = new EmployeeModel()
            };

            return View(model);
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IndexEmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeDto employee = new EmployeeDto
                    {
                        FirstName = model.Employee.FirstName,
                        LastName = model.Employee.LastName,
                    };
                    if(model.Employee.Photo != null)
                    {
                    var fullPath = $"{_wepHostEnvironment.WebRootPath}\\Images\\{Path.GetFileName(model?.Employee.Photo?.FileName)}";
                    await using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await model.Employee.Photo.CopyToAsync(stream);
                    }
                    employee.ImageUrl = $"/images/{Path.GetFileName(model.Employee.Photo.FileName)}";
                    }

                    _employeeService.Add(employee);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(Index), new IndexEmployeeViewModel { Employee = model.Employee});
                }
            }
            catch
            {
                return View();
            }
        }

       
    }
}
