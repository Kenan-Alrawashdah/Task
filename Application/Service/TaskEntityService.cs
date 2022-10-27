using Application.DTOs;
using Application.IService;
using Microsoft.EntityFrameworkCore;
using Persistence.AppContext;
using Persistence.Entities;
using Persistence.Entities.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class TaskEntityService : ITaskEntityService
    {
        private readonly AppDbContext _appDbContext;

        public TaskEntityService(AppDbContext appDbContext) => _appDbContext = appDbContext;


        public void Add(TaskDto entity)
        {

            List<Employee> employees = new List<Employee>();

            foreach(var empDto in entity.Employees ?? Enumerable.Empty<EmployeeDto>())
            {
                employees.Add(_appDbContext.Employees.Where(emp => emp.ID == empDto.ID).Single());
            }
            
            TaskEntity task = new TaskEntity
            {
                ActualCost = entity.ActualCost,
                Title = entity.Title,
                ParentId = entity.ParentId,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                TotalBudget = entity.TotalBudget,
                Status = entity.Status == StatusTask.DONE.ToString() ?
                        StatusTask.DONE :
                        entity.Status == StatusTask.INPROGRESS.ToString() ?
                        StatusTask.INPROGRESS : StatusTask.TODO,
                Employees = employees,
            };

            _appDbContext.Add(task);
            _appDbContext.SaveChanges();
        }

        public  IEnumerable<TaskDto> GetAll()
        {
            var tasks = _appDbContext.TasksEntitie
                        .Include(task => task.Employees)
                        .Include(task => task.Children)
                        .ThenInclude(task => task.Employees).ToList();
            return tasks.Select(task => new TaskDto
            {   
                ID = task.ID,
                Title = task.Title,
                Description = task.Description,
                ActualCost= task.ActualCost,
                TotalBudget= task.TotalBudget,
                Status = task.Status.ToString(),
                StartDate = task.StartDate,
                EndDate = task.EndDate,
                Employees = task.Employees.Select(emp => new EmployeeDto
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    ImageUrl = emp.ImageUrl,
                }).ToList(),
                Children = task.Children.Select(subTask => new TaskDto
                {
                    Title = task.Title,
                    Description = task.Description,
                    ActualCost = task.ActualCost,
                    TotalBudget = task.TotalBudget,
                    Status = task.Status.ToString(),
                    StartDate = task.StartDate,
                    EndDate = task.EndDate,
                    Employees = task.Employees.Select(emp => new EmployeeDto
                    {
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        ImageUrl = emp.ImageUrl,
                    }).ToList(),
                }).ToList()

            }).ToList();
        }

        public IEnumerable<TaskDto> GetTasksWithAssignedUsers()
        {
            throw new NotImplementedException();
        }
    }
}
