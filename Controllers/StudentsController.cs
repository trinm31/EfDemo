using EntityFramworkDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramworkDemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace EntityFramworkDemo.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var student = _db.Students.ToList();
            return View(student);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Upsert(int? id)
        {
            var student = new Student();
            if (id == null)
            {
                return View(student);
            }
            student = _db.Students.Find(id);
            return View(student);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Upsert(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.Id == null)
                {
                    _db.Students.Add(student);
                }

                if (student.Id != null)
                {
                    _db.Students.Update(student);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
