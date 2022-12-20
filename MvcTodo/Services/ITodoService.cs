using Microsoft.AspNetCore.Mvc.Rendering;
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
        void Update (Todo todo);
        //Prioraty SelectListItem
        public IEnumerable<SelectListItem> PrioritySelectListItems();
    }
}
