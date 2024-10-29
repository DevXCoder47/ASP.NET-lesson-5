using PracticeORM.Interfaces;
namespace PracticeORM.Data
{
    public class Repository : IRepository
    {
        private readonly ORMContext context;
        public Repository(ORMContext context)
        {
            this.context = context;
        }
        public IQueryable<T> GetAll<T>() where T : class
        {
            return context.Set<T>();
        }
    }
}
