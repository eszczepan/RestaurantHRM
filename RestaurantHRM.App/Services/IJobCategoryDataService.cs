using RestaurantHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantHRM.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}

