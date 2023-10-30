using Microsoft.AspNetCore.Mvc;

namespace NeyroHospital.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
