using Back_End.Models;
using Back_End.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    public class TodoListController : ControllerBase
    {
        private readonly TodoListService _service;

        public TodoListController(TodoListService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoList>>> GetTodoList()
        {
            return await _service.GetAllTodoLists();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoList>> GetTodoList(long id)
        {
            var list = await _service.GetTodoList(id);
            if (list == null)
            {
                return NotFound();
            }

            return list;
        }
        
        [HttpPost]
        public async Task<ActionResult<TodoList>> CreateTodoList(TodoList list)
        {
            var newList = await _service.CreateTodoList(list);
            return CreatedAtAction(nameof(GetTodoList), new { id = newList.Id }, newList);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoList(long id, TodoList list)
        {
            if (id != list.Id)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTodoList(list);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoList(long id)
        {
            await _service.DeleteTodoList(id);
            return NoContent();
        }
    }
}
