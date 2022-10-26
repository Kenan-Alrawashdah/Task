using Application.IService;
using Application.Service;

namespace MVC.Utils
{
    public static class ExtensionMethods
    {
        
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ITaskEntityService, TaskEntityService>();

        }
    }
}
