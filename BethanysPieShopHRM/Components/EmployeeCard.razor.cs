﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new ArgumentException("Employee.LastName is required");
            }
        }
    }
}