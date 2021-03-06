﻿using System.Collections.Generic;

namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; }

        public List<Student> Students { get; set; }

        public List<Mark> Marks { get; set; }
    }
}