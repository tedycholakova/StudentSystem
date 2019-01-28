using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "CourseName value is required. ")]
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public List<Mark> Marks { get; set; }
    }
}