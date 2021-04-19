using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EntityFramworkDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityFramworkDemo.Models;
using EntityFramworkDemo.Models.ViewModels;

namespace EntityFramworkDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            StudentCourseViewmodel studentCourseViewmodel = new StudentCourseViewmodel()
            {
                CourseList = _db.Courses.ToList(),
                StudentList = _db.Students.ToList()
            };
            return View(studentCourseViewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}