namespace StudentSystem.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public int StudentId { get; set; }      
        public virtual Student Student { get; set; }
        
    }
}