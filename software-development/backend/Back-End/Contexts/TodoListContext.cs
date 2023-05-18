using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Contexts
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoItemContext> options) : base(options) 
        { 
        }

        public DbSet<TodoList> TodoItems { get; set; } = null;

    }
}
