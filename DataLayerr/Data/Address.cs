namespace DataLayer.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        public int ZipCode { get; set; }

        [Required]
        public string Country { get; set; }

        public int StudentId { get; set; }

        public virtual StudentSystem.Models.Student Student { get; set; }
    }
}
