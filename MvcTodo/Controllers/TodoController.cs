using Microsoft.AspNetCore.Mvc;
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
    }
}
