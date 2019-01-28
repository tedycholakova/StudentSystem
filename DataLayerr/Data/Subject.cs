using System.Collections.Generic;

namespace DataLayer.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        [Required]
        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }
    }
}
