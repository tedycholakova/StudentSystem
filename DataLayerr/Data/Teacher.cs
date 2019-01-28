namespace DataLayer.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Invalid FirstName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Invalid FirstName value. The name is required and should be less than 50 symbols.")]
        [StringLength(50)]
        public string LastName { get; set; }
    }
}
