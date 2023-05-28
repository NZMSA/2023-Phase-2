namespace Back_End.Models
{
    public class TodoList
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public List<TodoItem>? TodoItemList { get; set; } = new List<TodoItem>();
    }
}
