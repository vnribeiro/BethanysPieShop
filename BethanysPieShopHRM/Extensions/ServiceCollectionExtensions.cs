using BethanysPieShopHRM.Data.Repositories;
using BethanysPieShopHRM.Data.Repositories.Interfaces;
using BethanysPieShopHRM.Data.Services;
using BethanysPieShopHRM.Data.Services.Interfaces;

namespace BethanysPieShopHRM.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection service)
        {
            //Repositories Injections
            service.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //Services Injections
            service.AddScoped<IEmployeeService, EmployeeService>();

            return service;
        }
    }
}
