namespace StudentSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
<<<<<<< HEAD

        public string FirstName { get; set; }

=======
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
>>>>>>> parent of a75a66e... Added validation attributes to models.
        public string LastName { get; set; }
    }
}
