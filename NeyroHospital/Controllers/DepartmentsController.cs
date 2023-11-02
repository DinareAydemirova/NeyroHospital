using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeyroHospital.DAL;
using NeyroHospital.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeyroHospital.Controllers
{
    public class DepartmentsController : Controller
    {
        public readonly AppDbContext _db;
        public DepartmentsController(AppDbContext db)
        {
            _db = db;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Department> departments = await _db.Departments.ToListAsync();
            return View(departments);
        }
        #endregion

        #region Create

        #region Get
        public IActionResult Create()
        {
            return View();
        }

        #endregion
       
        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department department)
        {
            bool isExist = await _db.Departments.AnyAsync(x => x.Name == department.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "There is a department with this name");
                return View();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _db.Departments.AddAsync(department);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        #endregion

        #endregion

        #region Update

        #region Get

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Department dbDepartment = await _db.Departments.FirstOrDefaultAsync(x => x.Id == id);
            if (dbDepartment == null)
            {
                return BadRequest();
            }
            return View(dbDepartment);
        }

        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Department department, int? id)
        {
            bool isExist = await _db.Departments.AnyAsync(x => x.Name == department.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "There is a department with this name");
                return View();
            }

            if (id == null)
            {
                return NotFound();
            }
            Department dbDepartment = await _db.Departments.FirstOrDefaultAsync(x => x.Id == id);
            if (dbDepartment == null)
            {
                return BadRequest();
            }

            dbDepartment.Name = department.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #endregion
       
        #region IsDeactive

        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Department dbDepartament = await _db.Departments.FirstOrDefaultAsync(x => x.Id == id);
            if (dbDepartament == null)
            {
                return BadRequest();
            }
            if (dbDepartament.IsDeactive)
            {
                dbDepartament.IsDeactive = false;
            }
            else
            {
                dbDepartament.IsDeactive = true;
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


    }
}
