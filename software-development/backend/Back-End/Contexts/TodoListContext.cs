using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Contexts
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
        {
        }

        public DbSet<TodoList> TodoLists { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<TodoList>()
                .HasMany(t => t.TodoItemList)
                .WithOne(i => i.TodoList)
                .HasForeignKey(i => i.TodoListId);
        }
    }
}
