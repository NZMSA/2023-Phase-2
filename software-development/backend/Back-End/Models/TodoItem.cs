using System.Text.Json.Serialization;

namespace Back_End.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public int TodoListItemId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDue { get; set; }
        public string Labels { get; set; }
        public string CreatedBy { get; set; }
        public ITEM_STATE State { get; set; }
        [JsonIgnore]
        public TodoList TodoList { get; set; }
    }

    public enum ITEM_STATE
    {
        TODO,
        DOING,
        DONE,
        OVERDUE
    }
}
