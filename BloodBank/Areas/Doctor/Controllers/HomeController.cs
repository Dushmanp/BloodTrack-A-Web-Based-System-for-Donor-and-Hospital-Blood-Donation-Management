using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Areas.Doctor.Controllers
{
    [Area("Doctor")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Auth.CheckDoctor();
            return View();
        }
    }
}
