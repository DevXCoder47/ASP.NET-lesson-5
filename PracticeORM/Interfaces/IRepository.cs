using PracticeORM.Models;

namespace PracticeORM.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
        void CreateDriver(Driver driver);
        void DeleteDriver(Driver driver);
        void UpdateDriver(Driver new_driver);
        void PatchDriverName(Driver new_driver, string first_name, string last_name);
    }
}
