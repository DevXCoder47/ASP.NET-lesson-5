using PracticeORM.Interfaces;
using PracticeORM.Models;

namespace PracticeORM.Services
{
    public class DriverService : IDriverService
    {
        private readonly IRepository repository;
        public DriverService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateDriver(Driver driver)
        {
            repository.CreateDriver(driver);
        }

        public void DeleteDriver(int id)
        {
            IEnumerable<Driver> drivers = repository.GetAll<Driver>();
            Driver driver = drivers.First(d => d.Id == id);
            repository.DeleteDriver(driver);
        }

        public Driver GetDriverByFirstName(string first_name)
        {
            IEnumerable<Driver> drivers = repository.GetAll<Driver>();
            return drivers.First(d => d.FirstName == first_name);
        }

        public Driver GetDriverById(int id)
        {
            IEnumerable<Driver> drivers = repository.GetAll<Driver>();
            return drivers.First(d => d.Id == id);
        }

        public ICollection<Driver> GetDrivers(int skip, int take)
        {
            return repository.GetAll<Driver>().Skip(skip).Take(take).ToArray();
        }

        public void PatchDriverName(int id, string first_name, string last_name)
        {
            IEnumerable<Driver> drivers = repository.GetAll<Driver>();
            Driver driver = drivers.First(d => d.Id == id);
            repository.PatchDriverName(driver, first_name, last_name);
        }
        public void UpdateDriver(int id, Driver new_driver)
        {
            new_driver.Id = id;
            repository.UpdateDriver(new_driver);
        }
    }
}
