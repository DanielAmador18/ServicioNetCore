namespace TaskManagerAPI.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
    }

    
}
