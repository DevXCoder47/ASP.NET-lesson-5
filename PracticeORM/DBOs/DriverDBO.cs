using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PracticeORM.DBOs
{
    public class DriverDBO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? DriverLicence { get; set; }
        public double Salary { get; set; }
    }
}
