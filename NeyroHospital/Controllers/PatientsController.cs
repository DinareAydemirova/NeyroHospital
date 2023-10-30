using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
