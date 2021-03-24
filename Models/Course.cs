using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFramworkDemo.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required] 
        public string Description { get; set; }
    }
}