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
        public ICollection<Driver> GetDrivers(int skip, int take)
        {
            return repository.GetAll<Driver>().Skip(skip).Take(take).ToArray();
        }
    }
}
