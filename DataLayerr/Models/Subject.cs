using System.Collections.Generic;

namespace StudentSystem.Models
{
    using DataLayer.Models;

    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers{ get; set; }
        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }
    }
}