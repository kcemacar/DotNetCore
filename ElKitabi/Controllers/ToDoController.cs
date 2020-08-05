using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElKitabi.Services;

namespace ElKitabi.Controllers
{
    

    public class TodoController : Controller
    {

        private readonly IToDoItemService _todoItemService;

    public ToDoController(IToDoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }

     public IActionResult Index()
    {
        var todoItems = await _todoItemService.GetIncompleteItemsAsync();
        var model = new TodoViewModel()
            {
                Items = todoItems
            };

            return View(model);
    }

}
}