using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    using DataLayer.Models;

    public class Mark
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }

    }
}