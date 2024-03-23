namespace ToDoApi.Models
{
    public class ToDoItemDTO
    {
        public long ToDoItemId { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
