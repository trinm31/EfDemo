using System.ComponentModel.DataAnnotations;

namespace EntityFramworkDemo.Models
{
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Major { get; set; }
    }
}