using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    using DataLayer.Models;

    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
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

