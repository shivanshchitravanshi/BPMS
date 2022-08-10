using Microsoft.AspNetCore.Mvc;

namespace BusPassManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
