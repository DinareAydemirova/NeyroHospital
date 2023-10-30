using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NeyroHospital.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NeyroHospital.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Error()
        {
            return View();
        }
    }
}
