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
            List<EmployeeModel> employees = _employeeService.GetAll().Select(employee => new EmployeeModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhotoName = employee.ImageUrl,
                CreateAt = employee.CreateAt,
            }).ToList();

            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeDto employee = new EmployeeDto
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                    }
                    ;
                    var fullPath = $"{_wepHostEnvironment.WebRootPath}\\Images\\{Path.GetFileName(model?.Photo?.FileName)}";
                    await using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await model.Photo.CopyToAsync(stream);
                    }
                    employee.ImageUrl = $"/images/{Path.GetFileName(model.Photo.FileName)}";

                    _employeeService.Add(employee);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: EmployeesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeesController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: EmployeesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
