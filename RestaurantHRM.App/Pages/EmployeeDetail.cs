using RestaurantHRM.Shared;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using RestaurantHRM.App.Services;

namespace RestaurantHRM.App.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter]
		public string EmployeeId { get; set; }
		public Employee Employee { get; set; } = new Employee();
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }
		protected async override Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}

	}
}
