using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class WardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
