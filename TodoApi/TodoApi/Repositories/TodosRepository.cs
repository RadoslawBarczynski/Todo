using TodoApi.Database;
using TodoApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodoApi.Repositories
{
    public class TodosRepository : ITodosRepository
    {
        private readonly ApplicationDbContext _context;

        public TodosRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Todo todo)
        {
            Guid myuuid = Guid.NewGuid();

            todo.id = myuuid;
            todo.Created_at = DateTime.UtcNow;

            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Todo result = _context.Todos.SingleOrDefault(x => x.id.Equals(id));

            if (result != null)
            {
                _context.Todos.Remove(result);
                _context.SaveChanges();
            }
        }

        public void CheckTodo(Guid id)
        {
            Todo result = _context.Todos.SingleOrDefault(x => x.id.Equals(id));

            if (result != null)
            {
                result.CompletedP = !result.CompletedP;
                _context.SaveChanges();
            }
        }

        public IQueryable<Todo> GetAllTodos(string filterDate)
        {
            DateOnly formatedFilter = DateOnly.ParseExact(filterDate, "yyyy-MM-dd");

            return _context.Todos
                .Where(t => t.Date == formatedFilter)
                .OrderBy(o => o.Created_at)
                .AsQueryable();
        }

        public void Update(Todo todo)
        {
            Todo result = _context.Todos.SingleOrDefault(x => x.id.Equals(todo.id));

            if(result != null)
            {
                result.Description = todo.Description;
                result.Date = todo.Date;

                _context.SaveChanges();
            }
        }
    }
}
