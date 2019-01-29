namespace DataLayer.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    using StudentSystem.Models;

    public class StudentSubjectMark
    {
       
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        public int MarkId { get; set; }

        public Mark Mark { get; set; }
    }
}
