using Back_End.Contexts;
using Back_End.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Controllers
{
    public static class TodoItemController
    {
        public static void MapTodoItemEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/TodoItem").WithTags(nameof(TodoItem));

            group.MapGet("/", async (TodoItemContext db) =>
            {
                return await db.TodoItems.ToListAsync();
            })
            .WithName("GetAllTodoItems")
            .WithOpenApi();

            group.MapGet("/{id}", async Task<Results<Ok<TodoItem>, NotFound>> (int id, TodoItemContext db) =>
            {
                return await db.TodoItems.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                    is TodoItem model
                        ? TypedResults.Ok(model)
                        : TypedResults.NotFound();
            })
            .WithName("GetTodoItemById")
            .WithOpenApi();

            group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, TodoItem todoItem, TodoItemContext db) =>
            {
                var affected = await db.TodoItems
                    .Where(model => model.Id == id)
                    .ExecuteUpdateAsync(setters => setters
                      .SetProperty(m => m.Id, todoItem.Id)
                      .SetProperty(m => m.TodoListItemId, todoItem.TodoListItemId)
                      .SetProperty(m => m.Title, todoItem.Title)
                      .SetProperty(m => m.Content, todoItem.Content)
                      .SetProperty(m => m.DateCreated, todoItem.DateCreated)
                      .SetProperty(m => m.DateDue, todoItem.DateDue)
                      .SetProperty(m => m.Labels, todoItem.Labels)
                      .SetProperty(m => m.CreatedBy, todoItem.CreatedBy)
                      .SetProperty(m => m.State, todoItem.State)
                    );

                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
            })
            .WithName("UpdateTodoItem")
            .WithOpenApi();

            group.MapPost("/", async (TodoItem todoItem, TodoItemContext db) =>
            {
                db.TodoItems.Add(todoItem);
                await db.SaveChangesAsync();
                return TypedResults.Created($"/api/TodoItem/{todoItem.Id}", todoItem);
            })
            .WithName("CreateTodoItem")
            .WithOpenApi();

            group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, TodoItemContext db) =>
            {
                var todoItem = await db.TodoItems.FindAsync(id);

                if (todoItem == null)
                {
                    return TypedResults.NotFound();
                }

                db.TodoItems.Remove(todoItem);
                await db.SaveChangesAsync();

                return TypedResults.Ok();
            })
            .WithName("DeleteTodoItem")
            .WithOpenApi();
        }
    }
}