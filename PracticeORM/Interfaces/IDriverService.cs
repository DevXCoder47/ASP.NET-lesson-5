using PracticeORM.Models;

namespace PracticeORM.Interfaces
{
    public interface IDriverService
    {
        ICollection<Driver> GetDrivers(int skip, int take);
    }
}
