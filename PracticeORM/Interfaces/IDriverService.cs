using PracticeORM.Models;

namespace PracticeORM.Interfaces
{
    public interface IDriverService
    {
        ICollection<Driver> GetDrivers(int skip, int take);
        void CreateDriver(Driver driver);
        Driver GetDriverByFirstName(string first_name);
        Driver GetDriverById(int id);
        void DeleteDriver(int id);
        void UpdateDriver(int id, Driver new_driver);
        void PatchDriverName(int id, string first_name, string last_name);
    }
}
