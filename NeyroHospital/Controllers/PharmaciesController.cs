using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class PharmaciesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
