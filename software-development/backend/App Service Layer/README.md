# App Service Layer

In a typical three-tier architecture, the service layer acts as a bridge between the database layer and the controller layer. This layer contains the business logic of the application. It communicates with the database layer to retrieve data, then applies business rules to that data. By separating business rules and data access, it makes data safer and code easier to maintain.

## Dependency Injection

In example 'Program.cs', we can find the following lines:

```c#
builder.Services.AddScoped<TodoItemService>();
builder.Services.AddScoped<TodoListService>();
```
The 'AddScoped' method means that a new instance of the service will be created for each web request. It ensures that the services' lifetime matches the database contexts' lifetime.

## Implementation
### Service Class

The 'TodoItemService.cs' is one of the service class. Both classes share a similar structure, including private field, constructuor and methods.

```c#
private TodoItemContext _itemContext;
```
In the private field, there is one _itemContext. It is an instance of 'TodoItemContext'.

```c#
public TodoItemService(TodoItemContext context)
{
    _itemContext = context;
}
```
The constructor takes an instance of 'TodoItemContext' as a parameter. This context is assigned to the '_itemContext' to be used throughout the class.

```c#
public async Task<TodoItem> CreateTodoItem(TodoItem item)
{
    _itemContext.TodoItems.Add(item);
    await _itemContext.SaveChangesAsync();
    return item;
}
```
Let us take this method as an example. It takes one TodoItem, adds it to 'TodoItems' collection in 'TOdoItemContext', saves changes to the database and return the new 'TodoItem'. The method is an asynchronously function, which is used to prevent blocking the main thread while saving the changes. Both Add() and SaveChangesAsync() are methods provided by Entity Framework Core. It is powerful and simplifies database operations.