using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class OutpatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
