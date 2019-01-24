using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Subject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Teacher> Teachers{ get; set; }
        [Required]
        public List<Mark> Marks { get; set; }
    }
}