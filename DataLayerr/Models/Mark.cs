using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}