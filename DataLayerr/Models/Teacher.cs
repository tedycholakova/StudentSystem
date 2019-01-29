namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name cannot be null or more than 50 symbols.")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name cannot be null or more than 50 symbols.")]
        [StringLength(50)]
        public string LastName { get; set; }
    }
}
