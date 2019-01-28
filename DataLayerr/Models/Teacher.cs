namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid FirstName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Invalid FirstName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string LastName { get; set; }
    }
}
