using EntityFramworkDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramworkDemo.Models;

namespace EntityFramworkDemo.Controllers
{
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

        [HttpPost]
        public IActionResult Upsert(Student student)
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
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
