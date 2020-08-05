using System;

namespace ElKitabi.Models
{
    public class ToDoItem
    {
        public Guid Id{get;set;}
    //GUID çok uzun bir yazı ve rasgele seçildiğinden dolayı aynı değerin üstüste gelmesi neredeyse imkansızdır. 

        public bool IsDone{get;set;}

        public string Title{get;set;}

        public DateTimeOffset? DueAt{get;set;}
        // Buradaki soru işareti null olabileceğini belirtir. 
    }
}

