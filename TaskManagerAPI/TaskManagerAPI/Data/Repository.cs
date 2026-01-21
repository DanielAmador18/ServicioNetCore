using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Entities;
using TaskManagerAPI.Repositories;

namespace TaskManagerAPI.Data
{

    public interface ITaskRepository
    {
        public Task<IEnumerable<TaskEntity>> GetAllTasksAsync();
        public Task<TaskEntity> GetTaskByIdAsync(int id);
        public Task AddTaskAsync(TaskEntity task);
        public Task UpdateTaskAsync(TaskEntity task);
        public Task DeleteTaskAsync(int id);

    }
    public class Repository : ITaskRepository
    {
        private readonly TaskDbContext _context;

        public Repository(TaskDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskEntity>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskEntity> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task AddTaskAsync(TaskEntity task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(TaskEntity task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int Id)
        {
            var task = await _context.Tasks.FindAsync(Id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
