namespace StudentSystem.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }
<<<<<<< HEAD

=======
>>>>>>> parent of a75a66e... Added validation attributes to models.
        public string City { get; set; }

        public int ZipCode { get; set; }
<<<<<<< HEAD

=======
>>>>>>> parent of a75a66e... Added validation attributes to models.
        public string Country { get; set; }

        public int StudentId { get; set; }      

        public virtual Student Student { get; set; }

    }
}