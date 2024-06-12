using BethanysPieShopHRM.Data.Repositories.Interfaces;
using BethanysPieShopHRM.Data.Services.Interfaces;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }
    }
}
