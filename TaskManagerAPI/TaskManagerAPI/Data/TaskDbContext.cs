using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Entities;

namespace TaskManagerAPI.Repositories
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {

        }
        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
