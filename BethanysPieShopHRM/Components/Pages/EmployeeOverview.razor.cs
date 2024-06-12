using BethanysPieShopHRM.Data.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        public string Tittle = "Employee Overview";

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}