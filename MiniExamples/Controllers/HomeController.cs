using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace MiniExamples.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return Content("Merhaba");
        }

        //Course/Details/2
        //Course/Details?id=2
        public IActionResult Details(int id)
        {
            return Content("id = "+ id);
        }

        // id? koyduğumuzda default 0 value değil de null value yapıyor


        public ActionResult AnotherDetails(int? pageindex,string sort)
        {
            if (!pageindex.HasValue)
            {
                pageindex = 1;
            }
            if(string.IsNullOrWhiteSpace(sort))
            {
                sort = "name";
            }


            return Content("pageindex = " + pageindex +"\n"+  "sort = " + sort); 
        }

       
    }
}
