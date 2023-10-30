using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class PositionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
