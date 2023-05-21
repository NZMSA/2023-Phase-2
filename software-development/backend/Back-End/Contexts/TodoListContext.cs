using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Contexts
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
        {
        }

        public DbSet<TodoList> TodoList { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .HasOne(p => p.TodoList)
                .WithMany(b => b.TodoItems)
                .HasForeignKey(p => p.TodoListItemId);
        }
    }
}