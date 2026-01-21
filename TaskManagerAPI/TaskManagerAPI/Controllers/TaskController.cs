using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Entities;
using TaskManagerAPI.Repositories;
namespace TaskManagerAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly ITaskRepository taskRepository;

        public TaskController(ITaskRepository _repository)
        {
            taskRepository = _repository;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskEntity>> GetTasks()
        {
            return await taskRepository.GetAllTasksAsync();
        }

        [HttpGet("{id}")]
        public async Task<TaskEntity> GetTaskById(int id)
        {
            return await taskRepository.GetTaskByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> AddTaskAsync([FromBody] TaskEntity task)
        {
            await taskRepository.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateTask(int id, [FromBody] TaskEntity task)
        {
            if (id != task.Id) return BadRequest();

            await taskRepository.UpdateTaskAsync(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteTask(int id)
        {
            await taskRepository.DeleteTaskAsync(id);
            return NoContent();
        }
    }
}
