using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentCRUDApplication.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public ICollection<Address>? Addresses { get; set; } //= new List<Address>();
    }
}
