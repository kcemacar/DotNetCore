using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElKitabi.Models;

// "Yapılacaklar'ı içeren listeyi içeren bir görev"
namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync();
    }
}