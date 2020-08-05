using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElKitabi.Models;

namespace ElKitabi.Services
{
    public class FakeToDoItemService : IToDoItemService
    {

        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            // Return an array of ToDoItems
            IEnumerable<ToDoItem> items = new[]
            {
                new ToDoItem
                {
                    Title = "Learn Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new ToDoItem
                {
                    Title = "Teach Core",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }

            };
            return Task.FromResult(items);
        }




    }
}