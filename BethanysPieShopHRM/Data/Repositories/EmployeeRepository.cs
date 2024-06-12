using BethanysPieShopHRM.Data.Repositories.Interfaces;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId == id);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
