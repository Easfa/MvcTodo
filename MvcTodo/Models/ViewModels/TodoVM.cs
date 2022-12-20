using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcTodo.Models.ViewModels
{
    public class TodoVM
    {
        public Todo? Todo { get; set; }

        public IEnumerable<SelectListItem>? PriorityDropDown { get; set; }
    }
}
