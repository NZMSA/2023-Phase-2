namespace Back_End.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDue { get; set; }
        public List<string> Labels { get; set; }
        public string CreatedBy { get; set; }
        public ITEM_STATE State { get; set; }

    }

    public enum ITEM_STATE
    {
        TODO,
        DOING,
        DONE,
        OVERDUE
    }
}
