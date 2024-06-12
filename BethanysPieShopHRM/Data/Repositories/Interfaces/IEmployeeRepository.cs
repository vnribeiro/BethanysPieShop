using BethanysPieShopHRM.Shared.Data;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee?> GetEmployeeById(int id);
    }
}
