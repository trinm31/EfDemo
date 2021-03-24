using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramworkDemo.Models
{
    public class Enroll
    {
        [Key] 
        public int Id { get; set; }
        public DateTime EnrollDate { get; set; }
        [Required] 
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [Required] 
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}