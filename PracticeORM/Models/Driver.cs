namespace PracticeORM.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? DriverLicence { get; set; }
        public double Salary { get; set; }
    }
}
