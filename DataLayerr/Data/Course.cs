namespace DataLayer.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "CourseName value is required. ")]
        public string CourseName { get; set; }

        public List<StudentSystem.Models.Student> Students { get; set; }

        public List<StudentSystem.Models.Mark> Marks { get; set; }
    }
}
