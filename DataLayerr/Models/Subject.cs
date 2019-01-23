using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers{ get; set; }
        public List<Mark> Marks { get; set; }
    }
}