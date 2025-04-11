using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentCRUDApplication.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Required]
        public required string AddressLine { get; set; }
        [Required]
        public required string City { get; set; }
        [Required]
        public required string State { get; set; }
        [Required]
        public required string ZipCode { get; set; }
        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student? Student { get; set; }
    }
}
