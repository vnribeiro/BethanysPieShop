using BethanysPieShopHRM.Data.Services;

namespace BethanysPieShopHRM.Components.Widgets
{
    public partial class EmployeeCountWidget
    {
        public int EmployeeCounter { get; set; }

        protected override void OnInitialized()
        {
            EmployeeCounter = MockDataService.Employees!.Count;
        }
    }
}