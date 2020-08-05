using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bukimedia.PrestaSharp.Factories;
using Microsoft.AspNetCore.Mvc;

namespace PrestaShopar.Controllers
{
    [Route("[controller]")]
    public class AddressController : Controller
    {

        string BaseUrl = "http://www.enyares.com/api";
        string apiKey = "" //key;
        string Password = "";

        AddressFactory _addressFactory;



        public AddressController()
        {
            _addressFactory = new AddressFactory(BaseUrl, apiKey, Password);
        }

        public IActionResult Index()
        {
            

            return Ok(_addressFactory.GetAll());
        }


        [HttpPost("/[controller]")]
        public IActionResult Addresses([FromBody] Bukimedia.PrestaSharp.Entities.address address)
        {
            try
            {
                // minumum requirement saglanmiyorsa catch'e dusecek
                _addressFactory.Add(address);
            }
            catch (Exception exception)
            {
                return BadRequest();
            }

            return Ok();
        }


    }
}




