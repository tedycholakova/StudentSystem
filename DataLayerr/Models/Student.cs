using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Course Course { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public virtual Address Addresss { get; set; }
    }
}

