using Microsoft.EntityFrameworkCore;
using PracticeORM.Models;
namespace PracticeORM.Data
{
    public class ORMContext : DbContext
    {
        public ORMContext(DbContextOptions<ORMContext> options) : base(options)
        {
        }
        public DbSet<Driver> Drivers { get; set; }
    }
}
