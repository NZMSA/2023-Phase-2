using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Contexts
{
    public class TodoItemContext : DbContext
    {
        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options) 
        { 
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null;

    }
}
