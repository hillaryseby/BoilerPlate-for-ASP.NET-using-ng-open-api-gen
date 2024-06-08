using WebApi.DataTransferObjects;

namespace WebApi.Interfaces.Services
{
    public interface ITaskService
    {
        Task<List<TaskDto>> GetAllTasks();
        System.Threading.Tasks.Task AddNewTask(TaskDto task);
    }
}