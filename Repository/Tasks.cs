
using WebApi.DataTransferObjects;
using WebApi.Interfaces.Repositories;

namespace WebApi.Repository
{
    public class Tasks : ITasksRepository
    {
        private readonly TodoListContext dbContext;
        public Tasks(TodoListContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TaskDto>> GetTasks()
        {
            return this.dbContext.Tasks.Select(task => new TaskDto()
            {
                Id = task.TaskId,
                Name = task.TaskName
            }).ToList();

        }
     
        public async System.Threading.Tasks.Task AddNewTask(TaskDto tasks)
        {
            var model = new TaskTranslation()
            {
                TaskId = tasks.Id,
                TimeStamp = DateTime.UtcNow,
                UserId = tasks.Id.ToString(),
            
            };
             this.dbContext.Add(model);

            var task = new Models.Task
            {
                TaskId = tasks.Id,
                TaskName = tasks.Name
            };
            this.dbContext.Tasks.Add(task);
            await this.dbContext.SaveChangesAsync();
            
        }
    }
}
