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
        public JsonResult GetTodos(string filterDate)
        {
            return new JsonResult(_todosRepository.GetAllTodos(filterDate));
        }

        [HttpPost("AddTodo")]
        public IActionResult AddTodo([FromForm] string jsonTodo)
        {
            Todo todo = new Todo();
            todo = JsonConvert.DeserializeObject<Todo>(jsonTodo);

            _todosRepository.Add(todo);

            return Ok(jsonTodo);
        }

        [HttpPost("DeleteTodo")]
        public IActionResult DeleteTodo([FromForm] Guid jsonId)
        {
            Guid id = jsonId;

            _todosRepository.Delete(id);

            return Ok(jsonId);
        }

        [HttpPost("UpdateTodo")]
        public IActionResult UpdateTodo([FromForm] string jsonTodo)
        {
            Todo todo = JsonConvert.DeserializeObject<Todo>(jsonTodo);

            _todosRepository.Update(todo);

            return Ok(jsonTodo);
        }

        [HttpPost("CheckTodo")]
        public IActionResult CheckTodo([FromForm] Guid jsonId)
        {
            Guid id = jsonId;

            _todosRepository.CheckTodo(id);

            return Ok(jsonId);
        }
    }
}
