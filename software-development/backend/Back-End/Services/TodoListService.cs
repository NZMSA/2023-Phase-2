using Microsoft.EntityFrameworkCore;
using Back_End.Models;
using Back_End.Contexts;

namespace Back_End.Services
{
    public class TodoListService 
    {
        private TodoListContext _listContext;

        public TodoListService (TodoListContext context)
        {
            _listContext = context;
        }

        public async Task<TodoList> CreateTodoList(TodoList list) 
        {
            _listContext.TodoLists.Add(list);
            await _listContext.SaveChangesAsync();
            return list;
        }

        public async Task<List<TodoList>> GetAllTodoLists() 
        {
            return await _listContext.TodoLists.Include(l => l.TodoItemList).ToListAsync();
        }

        public async Task<TodoList> GetTodoList(long id)
        {
            return await _listContext.TodoLists.Include(l => l.TodoItemList).FirstOrDefaultAsync(l => l.Id == id);
        }
        
        public async Task UpdateTodoList(TodoList list)
        {
            _listContext.Entry(list).State = EntityState.Modified;
            await _listContext.SaveChangesAsync();
        }

        public async Task DeleteTodoList(long id)
        {
            var list = await _listContext.TodoLists.FindAsync(id);
            _listContext.TodoLists.Remove(list);
            await _listContext.SaveChangesAsync();
        }
    }    
}
