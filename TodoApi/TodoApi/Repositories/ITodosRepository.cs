using TodoApi.Models;

namespace TodoApi.Repositories
{
    public interface ITodosRepository
    {
        void CheckTodo(Guid id);
        IQueryable<Todo> GetAllTodos(string filterDate);
        void Add(Todo todo);
        void Update(Todo todo);
        void Delete(Guid id);
    }
}
