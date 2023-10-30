using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
