using System.Collections.Generic;

namespace StudentSystem.Models
{
    using DataLayer.Models;

    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }

    }
}