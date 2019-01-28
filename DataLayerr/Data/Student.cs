using System;
using System.Collections.Generic;

namespace DataLayer.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Invalid FirstName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Invalid LastName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public virtual Course Course { get; set; }

        public virtual HashSet<Subject> Subjects { get; set; }

        public virtual List<Mark> Marks { get; set; }

        public virtual Address Address { get; set; }

        public virtual HashSet<StudentSubjectMark> StudentSubjectMarks { get; set; }
    }
}
