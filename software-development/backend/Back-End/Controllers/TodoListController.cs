using Back_End.Contexts;
using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Back_End.Controllers
{
    public static class TodoListController
    {
        public static void MapTodoListEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/TodoList").WithTags(nameof(TodoList));

            group.MapGet("/", async (TodoListContext db) =>
            {
                return await db.TodoList.ToListAsync();
            })
            .WithName("GetAllTodoLists")
            .WithOpenApi();

            group.MapGet("/{id}", async Task<Results<Ok<TodoList>, NotFound>> (int id, TodoListContext db) =>
            {
                return await db.TodoList.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                    is TodoList model
                        ? TypedResults.Ok(model)
                        : TypedResults.NotFound();
            })
            .WithName("GetTodoListById")
            .WithOpenApi();

            group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, TodoList todoList, TodoListContext db) =>
            {
                var existingList = await db.TodoList.FindAsync(id);

                if (existingList == null)
                {
                    return TypedResults.NotFound();
                }

                existingList.Title = todoList.Title;
                existingList.CreatedBy = todoList.CreatedBy;
                existingList.DateCreated = todoList.DateCreated;

                await db.SaveChangesAsync();

                return TypedResults.Ok();
            })
            .WithName("UpdateTodoList")
            .WithOpenApi();

            group.MapPost("/", async (TodoList todoList, TodoListContext db) =>
            {
                db.TodoList.Add(todoList);
                await db.SaveChangesAsync();
                return TypedResults.Created($"/api/TodoList/{todoList.Id}", todoList);
            })
            .WithName("CreateTodoList")
            .WithOpenApi();

            group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, TodoListContext db) =>
            {
                var existingList = await db.TodoList.FindAsync(id);

                if (existingList == null)
                {
                    return TypedResults.NotFound();
                }

                db.TodoList.Remove(existingList);
                await db.SaveChangesAsync();

                return TypedResults.Ok();
            })
            .WithName("DeleteTodoList")
            .WithOpenApi();
        }
    }
}