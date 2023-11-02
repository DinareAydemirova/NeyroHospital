using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class InpatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
