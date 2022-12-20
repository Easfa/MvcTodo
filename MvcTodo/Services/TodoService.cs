using Microsoft.AspNetCore.Mvc.Rendering;
using MvcTodo.Data;
using MvcTodo.Models;

namespace MvcTodo.Services
{
    public class TodoService : ITodoService
    {
        private AppDbContext _db;
        public TodoService(AppDbContext db) { _db = db; }

        public void Add(Todo todo)
        {
            _db.Add(todo);
        }

        public IEnumerable<Todo> GetActiveTodos()
        {
            return _db.Todos.Where(x => x.IsComplete == false);
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _db.Todos.Select(x => x);
        }

        public Todo GetTodoById(int id)
        {
            return _db.Todos.Find(id);
        }

        public void Update(Todo todo)
        {
            _db.Update(todo);
        }

        public IEnumerable<SelectListItem> PrioritySelectListItems()
        {
            return _db.Todos.Select(x => new SelectListItem
            {
                Value = x.Priority.ToString(),
                Text = x.PrioratyText
            });
        }
    }
}
