using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    using StudentSystem.Models;

    public class StudentSubjectMark
    {
        [Key ]
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
