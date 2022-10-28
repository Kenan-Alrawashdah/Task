using Microsoft.EntityFrameworkCore;
using Persistence.Entities;
using Persistence.Entities.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.AppContext
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee{ID = 1, FirstName = "Kenan", LastName = "Rawashdah", ImageUrl = "/Images/em1.png" },
               new Employee{ID = 2, FirstName = "Noor", LastName = "Rawashdah", ImageUrl = "/Images/emp2.jpg" },
               new Employee{ID = 3, FirstName = "Zaher", LastName = "Rawashdah", ImageUrl = "/Images/emp5.png" },
               new Employee{ID = 4, FirstName = "Mohamad", LastName = "Rawashdah"}
            );


            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity { ID = 1, Title = "Task1", Description = "test test", ActualCost = 7000, TotalBudget = 10000, Status = StatusTask.INPROGRESS, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5) },
                new TaskEntity { ID = 2, Title = "Task2", Description = "test test", ActualCost = 4000, TotalBudget = 11000, Status = StatusTask.TODO, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(10) },
                new TaskEntity { ID = 3, Title = "Task3", Description = "test test", ActualCost = 5000, TotalBudget = 8000, Status = StatusTask.INPROGRESS, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(15) },
                new TaskEntity { ID = 4, Title = "Task4", Description = "test test", ActualCost = 2000, TotalBudget = 7000, Status = StatusTask.DONE, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(20) },

                new TaskEntity { ID = 5, ParentId = 1, Title = "Sub1", Description = "test test", ActualCost = 3000, TotalBudget = 6000, Status = StatusTask.INPROGRESS, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(10) },
                new TaskEntity { ID = 6, ParentId = 1, Title = "Sub2", Description = "test test", ActualCost = 2500, TotalBudget = 4000, Status = StatusTask.DONE, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5) },
                new TaskEntity { ID = 7, ParentId = 1, Title = "Sub3", Description = "test test", ActualCost = 500, TotalBudget = 1000, Status = StatusTask.TODO, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3) },

                new TaskEntity { ID = 8, ParentId = 2, Title = "Sub1", Description = "test test", ActualCost = 4000, TotalBudget = 7000, Status = StatusTask.TODO, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(6) },
                new TaskEntity { ID = 9, ParentId = 2, Title = "Sub2", Description = "test test", ActualCost = 2000, TotalBudget = 4000, Status = StatusTask.INPROGRESS, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3) },

                new TaskEntity { ID = 10, ParentId = 4, Title = "Sub1", Description = "test test", ActualCost = 3000, TotalBudget = 7000, Status = StatusTask.DONE, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) }

               );

            modelBuilder
             .Entity<TaskEntity>()
             .HasMany(t => t.Employees)
             .WithMany(e => e.TasksEntity)
             .UsingEntity(j => j.HasData(
                 new { TasksEntityID = 1, EmployeesID = 1 },
                 new { TasksEntityID = 1, EmployeesID = 2 },
                 new { TasksEntityID = 1, EmployeesID = 3 },
                 new { TasksEntityID = 1, EmployeesID = 4 },

                 new { TasksEntityID = 2, EmployeesID = 1 },
                 new { TasksEntityID = 2, EmployeesID = 3 },
                 new { TasksEntityID = 2, EmployeesID = 4 },

                 new { TasksEntityID = 3, EmployeesID = 2 },
                 new { TasksEntityID = 3, EmployeesID = 3 },

                 new { TasksEntityID = 4, EmployeesID = 1 },

                 new { TasksEntityID = 5, EmployeesID = 1 },
                 new { TasksEntityID = 5, EmployeesID = 2 },
                 new { TasksEntityID = 6, EmployeesID = 3 },
                 new { TasksEntityID = 6, EmployeesID = 4 },

                 new { TasksEntityID = 7, EmployeesID = 1 },
                 new { TasksEntityID = 8, EmployeesID = 3 },
                 new { TasksEntityID = 8, EmployeesID = 4 },

                 new { TasksEntityID = 9, EmployeesID = 2 },
                 new { TasksEntityID = 9, EmployeesID = 3 },

                 new { TasksEntityID = 10, EmployeesID = 1}
                 ));

        }
    }
}
