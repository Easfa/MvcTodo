using MvcTodo.Models;
using System.Collections.Generic;

namespace MvcTodo.Services
{
    public interface ITodoService
    {
        //GetActiveTodos
        IEnumerable<Todo> GetActiveTodos();
        //GetAllTodos
        IEnumerable<Todo> GetAllTodos();
        //GetTodoById
        Todo GetTodoById(int id);
        //Add
        void Add(Todo todo);
        //Update
        void update (Todo todo);
    }
}
