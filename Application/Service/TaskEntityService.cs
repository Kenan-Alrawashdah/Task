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
    public class TaskEntityService : ITaskEntityService
    {
        private readonly AppDbContext _appDbContext;

        public TaskEntityService(AppDbContext appDbContext) => _appDbContext = appDbContext;


        public void Add(TaskEntity entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public  IEnumerable<TaskEntity> GetAll()
        {
           return  _appDbContext.TasksEntitie.ToList();
        }
    }
}
