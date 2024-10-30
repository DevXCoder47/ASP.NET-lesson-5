using PracticeORM.Interfaces;
using PracticeORM.Models;
namespace PracticeORM.Data
{
    public class Repository : IRepository
    {
        private readonly ORMContext context;
        public Repository(ORMContext context)
        {
            this.context = context;
        }
        public void CreateDriver(Driver driver)
        {
            context.Drivers.Add(driver);
            context.SaveChanges();
        }
        public void DeleteDriver(Driver driver)
        {
            context.Drivers.Remove(driver);
            context.SaveChanges();
        }
        public void UpdateDriver(Driver new_driver)
        {
            context.Drivers.Update(new_driver);
            context.SaveChanges();
        }
        
        public IQueryable<T> GetAll<T>() where T : class
        {
            return context.Set<T>();
        }

        public void PatchDriverName(Driver new_driver, string first_name, string last_name)
        {
            context.Drivers.Attach(new_driver);
            new_driver.FirstName = first_name;
            new_driver.LastName = last_name;
            context.Entry(new_driver).Property(e => e.FirstName).IsModified = true;
            context.Entry(new_driver).Property(e => e.LastName).IsModified = true;
            context.SaveChanges();
        }
    }
}
