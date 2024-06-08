using WebApi.DataTransferObjects;

namespace WebApi.Interfaces.Repositories
{
    public interface ITasksRepository
    {
        Task<List<TaskDto>> GetTasks();
        System.Threading.Tasks.Task AddNewTask(TaskDto task);
    }
}