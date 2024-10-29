using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeORM.Models
{
    [Table("Drivers")]
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? DriverLicence { get; set; }
        public double Salary { get; set; }
    }
}
