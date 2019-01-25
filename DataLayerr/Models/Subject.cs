using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    using DataLayer.Models;

    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Teacher> Teachers{ get; set; }
        [Required]

        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }


    }
}