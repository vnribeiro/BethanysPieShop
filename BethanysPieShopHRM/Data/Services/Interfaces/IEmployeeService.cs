using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Data.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee?> GetEmployeeById(int id);
    }
}
