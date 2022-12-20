using Microsoft.AspNetCore.Mvc;
using MvcTodo.Models;
using MvcTodo.Models.ViewModels;
using MvcTodo.Services;

namespace MvcTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _service;
        public TodoController(ITodoService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetActiveTodos());
        }

        public IActionResult AddOrUpdate(int id)
        {
            TodoVM todovm = new TodoVM()
            {
                Todo = new Todo(),
                PriorityDropDown = _service.PrioritySelectListItems()

            };
            if (id == 0)
                return View(todovm);
            else
            {
                todovm.Todo = _service.GetTodoById(id);
                return View(todovm);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrUpdate(Todo todo)
        {
            if (todo.Id == 0)
            {
                _service.Add(todo);
            }
            else
            {
                _service.Update(todo);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Done(int id) 
        {
            _service.SetDone(id);
            return RedirectToAction("Index");
        }
    }
}
