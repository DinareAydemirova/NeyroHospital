using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class LabResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
