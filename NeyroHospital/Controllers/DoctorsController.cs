using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeyroHospital.DAL;
using NeyroHospital.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeyroHospital.Controllers
{
    public class DoctorsController : Controller
    {
        public readonly AppDbContext _db;
        public DoctorsController(AppDbContext db)
        {
            _db = db;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Doctor> doctors = await _db.Doctors.Include(x=>x.Department).Include(x=>x.DocOffice).ToListAsync();
            return View(doctors);
        }
        #endregion


        #region Create

        #region Get
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _db.Departments.ToListAsync();

            return View();
        }

        #endregion

        #endregion
    }
}
