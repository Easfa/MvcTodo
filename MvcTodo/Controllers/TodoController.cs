using Microsoft.AspNetCore.Mvc;

namespace MvcTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
