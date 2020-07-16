using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{

    public class Student
    {
        

        public string Name{get;set;}
       
        [Required(ErrorMessage= "Email girmek zorunludur")]
        public string Email{get;set;}

        
        public string Phone{get;set;}
        public bool? Confirm{get;set;} // true, false,null
    }


}