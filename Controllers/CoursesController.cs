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
    [Authorize(Roles = "Staff")]
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CoursesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var course = _db.Courses.ToList();
            return View(course);
        }
    }
}