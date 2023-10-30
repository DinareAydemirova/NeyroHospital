using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class DocOfficesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
