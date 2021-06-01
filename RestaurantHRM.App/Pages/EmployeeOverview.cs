using Microsoft.AspNetCore.Components;
using RestaurantHRM.App.Services;
using RestaurantHRM.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantHRM.App.Pages
{
    public partial class EmployeeOverview
    {
		public IEnumerable<Employee> Employees { get; set; }
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
		}

	}
}

