using Microsoft.AspNetCore.Mvc;

namespace RestaurantHRM.Api.Controllers
{
    public class Country : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
