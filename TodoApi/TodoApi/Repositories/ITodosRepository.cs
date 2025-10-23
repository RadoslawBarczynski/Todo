using TodoApi.Models;

namespace TodoApi.Repositories
{
    public interface ITodosRepository
    {
        Todo Get(Guid id);
        IQueryable<Todo> GetAllTodos();
        void Add(Todo todo);
        void Update(Guid id, Todo todo);
        void Delete(Guid id);
    }
}
