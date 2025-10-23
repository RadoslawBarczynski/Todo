using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApi.Database;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodosRepository _todosRepository;

        public TodoController(ITodosRepository todosRepository)
        {
            _todosRepository = todosRepository;
        }

        [HttpGet]
        [Route("GetTodos")]
        public JsonResult GetTodos()
        {
            return new JsonResult(_todosRepository.GetAllTodos());
        }

        [HttpPost("AddTodo")]
        public IActionResult AddTodo([FromForm] string jsonTodo)
        {
            Todo todo = new Todo();
            todo = JsonConvert.DeserializeObject<Todo>(jsonTodo);

            _todosRepository.Add(todo);

            return Ok(jsonTodo);
        }
    }
}
