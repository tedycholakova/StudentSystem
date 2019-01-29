using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
<<<<<<< HEAD

=======
        [Required]
>>>>>>> parent of a75a66e... Added validation attributes to models.
        public string CourseName { get; set; }

        public List<Student> Students { get; set; }

        public List<Mark> Marks { get; set; }
    }
}