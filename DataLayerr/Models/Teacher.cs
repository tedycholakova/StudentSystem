﻿namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
    }
}
