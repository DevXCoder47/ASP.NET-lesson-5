namespace PracticeORM.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
    }
}
