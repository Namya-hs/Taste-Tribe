using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
