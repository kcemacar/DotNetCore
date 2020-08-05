using System.Collections.Generic;

namespace ElKitabi.Models
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDoItem> Items {get;set;}
    }

// IEnumerable<> : Bu özellik boş olabilir, bir tane veya daha fazla TodoItem içerebilir.

}