using System.Collections.Generic;

namespace EntityFramworkDemo.Models.ViewModels
{
    public class StudentCourseViewmodel
    {
        public IEnumerable<Course> CourseList { get; set; }
        public IEnumerable<Student> StudentList { get; set; }
    }
}