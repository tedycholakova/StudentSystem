namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        public int ZipCode { get; set; }
        [Required]
        public string Country { get; set; }

        public int StudentId { get; set; }      
        public virtual Student Student { get; set; }
        
    }
}