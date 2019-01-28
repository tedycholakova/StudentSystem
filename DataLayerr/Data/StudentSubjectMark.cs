namespace DataLayer.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StudentSubjectMark
    {
        [Key]
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Key]
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        [Key]
        [ForeignKey("Mark")]
        public int MarkId { get; set; }

        public Mark Mark { get; set; }
    }
}
