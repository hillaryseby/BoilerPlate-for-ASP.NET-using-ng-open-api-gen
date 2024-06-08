namespace WebApi.DataTransferObjects
{
    public class TaskDto
    {
        public long Id { get; set; }
        public string Name { get; set; } =string.Empty;

        public long UserId { get; set; }
    }
}
