using WebApi.DataTransferObjects;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;

namespace WebApi.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITasksRepository _tasksRepository;

        public TaskService(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public async System.Threading.Tasks.Task AddNewTask(TaskDto task)
        {
            await _tasksRepository.AddNewTask(task);
        }

        public async Task<List<TaskDto>> GetAllTasks()
        {
            return await this._tasksRepository.GetTasks();
        }

      
    }
}
