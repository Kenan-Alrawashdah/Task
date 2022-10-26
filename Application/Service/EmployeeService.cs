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

        public void Add(Employee entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _appDbContext.Employees.ToList();
        }
    }
}
