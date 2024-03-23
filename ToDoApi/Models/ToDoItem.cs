using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public long ToDoItemId { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }

    }
}
