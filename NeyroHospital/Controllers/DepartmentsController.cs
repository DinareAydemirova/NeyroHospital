using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
