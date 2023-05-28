using System.Text.Json.Serialization;

namespace Back_End.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDue { get; set; }
        public List<Label> Labels { get; set; } = new List<Label>();
        public string CreatedBy { get; set; }
        public ITEM_STATE State { get; set; }
        public long TodoListId { get; set; }
        [JsonIgnore]
        public TodoList? TodoList { get; set; }
    }

    public class Label
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long TodoItemId { get; set; }
        [JsonIgnore]
        public TodoItem? TodoItem { get; set; }
    }

    public enum ITEM_STATE
    {
        TODO,
        DOING,
        DONE,
        OVERDUE
    }
}
