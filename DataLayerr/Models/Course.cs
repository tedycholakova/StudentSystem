using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }
}