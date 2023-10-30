using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
