using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Contexts
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoItemContext> options) : base(options) 
        { 
        }

        // how's about changing this name to TodoLists?
        public DbSet<TodoList> TodoLists { get; set; } = null;

    }
}
