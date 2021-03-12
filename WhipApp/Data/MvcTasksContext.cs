using Microsoft.EntityFrameworkCore;
using WhipApp.Models;

namespace WhipApp.Data
{
    public class MvcTasksContext : DbContext
    {
        public MvcTasksContext(DbContextOptions<MvcTasksContext> options)
            : base(options)
        {
        }

        public DbSet<TodoTask> TodoTask { get; set; }
    }
}
