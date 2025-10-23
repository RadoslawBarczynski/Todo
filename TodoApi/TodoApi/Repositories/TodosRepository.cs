using TodoApi.Database;
using TodoApi.Models;

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

            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Todo Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Todo> GetAllTodos()
        {
            return _context.Todos.AsQueryable();
        }

        public void Update(Guid id, Todo student)
        {
            throw new NotImplementedException();
        }
    }
}
