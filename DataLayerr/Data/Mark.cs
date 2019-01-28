namespace DataLayer.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mark have to have a name. ")]
        public string Name { get; set; }
        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }
                
    }
}
