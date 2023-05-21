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
                var existingItem = await db.TodoItems.FindAsync(id);

                if (existingItem == null)
                {
                    return TypedResults.NotFound();
                }

                existingItem.TodoListItemId = todoItem.TodoListItemId;
                existingItem.Title = todoItem.Title;
                existingItem.Content = todoItem.Content;
                existingItem.DateCreated = todoItem.DateCreated;
                existingItem.DateDue = todoItem.DateDue;
                existingItem.Labels = todoItem.Labels;
                existingItem.CreatedBy = todoItem.CreatedBy;
                existingItem.State = todoItem.State;

                await db.SaveChangesAsync();

                return TypedResults.Ok();
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