using System.ComponentModel.DataAnnotations;

namespace EntityFramworkDemo.Models
{
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [Required(ErrorMessage = "Nguyen ngu dien vo cho ta")]
        public string Name { get; set; }
        [Range(1,100)]
        public int? Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Major { get; set; }
    }
}