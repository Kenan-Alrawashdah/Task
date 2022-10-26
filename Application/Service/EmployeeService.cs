using Application.DTOs;
using Application.IService;
using Persistence.AppContext;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public void Add(EmployeeDto entity)
        {
            _appDbContext.Add(new Employee
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                ImageUrl = entity?.ImageUrl,
            });
            _appDbContext.SaveChanges();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {  
                var employees = _appDbContext.Employees.ToList();

            return employees.Select(employee => new EmployeeDto
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                ImageUrl = employee?.ImageUrl
            });
        }
    }
}
