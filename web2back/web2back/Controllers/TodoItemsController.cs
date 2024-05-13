using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web2back.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : ControllerBase
    {
        private static readonly List<TodoItem> _items = new List<TodoItem>
    {
        new TodoItem { Id = 1, Title = "Buy groceries", IsCompleted = false },
        new TodoItem { Id = 2, Title = "Read a book", IsCompleted = true }
    };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_items);
        }
    }

}
