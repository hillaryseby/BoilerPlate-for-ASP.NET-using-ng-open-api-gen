using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebApi.DataTransferObjects;
using WebApi.Interfaces.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Task : ControllerBase
    {
        private readonly TodoListContext dbContext;
        private readonly ITaskService taskService;

        public Task(TodoListContext dbContext, ITaskService taskService)
        {
            this.dbContext = dbContext;
            this.taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var tasks = await this.taskService.GetAllTasks();
            return Ok(tasks);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> AddNewTask([FromBody] TaskDto task)
        {
            await this.taskService.AddNewTask(task);
            return Ok();
        }
    }
}
