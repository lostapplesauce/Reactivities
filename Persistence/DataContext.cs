using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //This represents the table name; Activities
        public DbSet<Activity> Activities { get; set; }
    }
}