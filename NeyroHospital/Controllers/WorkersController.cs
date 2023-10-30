using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class WorkersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
