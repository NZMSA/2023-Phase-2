using Microsoft.EntityFrameworkCore;
using Back_End.Models;
using Back_End.Contexts;

namespace Back_End.Services
{
    public class TodoItemService
    {
        private TodoItemContext _itemContext;

        public TodoItemService(TodoItemContext context)
        {
            _itemContext = context;
        }

        public async Task<TodoItem> CreateTodoItem(TodoItem item)
        {
            _itemContext.TodoItems.Add(item);
            await _itemContext.SaveChangesAsync();
            return item;
        }

        public async Task<TodoItem> GetTodoItem(long id)
        {
            return await _itemContext.TodoItems.FindAsync(id);
        }

        public async Task UpdateTodoItem(TodoItem item)
        {
            _itemContext.Entry(item).State = EntityState.Modified;
            await _itemContext.SaveChangesAsync();
        }

        public async Task DeleteTodoItem(long id) 
        {
            var item = await _itemContext.TodoItems.FindAsync(id);
            _itemContext.TodoItems.Remove(item);
            await _itemContext.SaveChangesAsync();
        }
    }
}