using Microsoft.AspNetCore.Mvc;

namespace AroosAlBahr.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
