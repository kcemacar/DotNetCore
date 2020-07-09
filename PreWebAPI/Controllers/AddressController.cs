using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bukimedia.PrestaSharp.Factories;
using Microsoft.AspNetCore.Mvc;

namespace PrestaDeneme.Controllers
{
    public class AddressController : Controller
    {
        private readonly AddressFactory _adressfactory; // hazır kütüphaneden çekiyor. 
        string BaseUrl = "http://localhost/prestashop/api";
        string Account = "V7UIRUC73SBY9ZNAI3GAIN3FKY17E8PV";
        string Password = "";

        public AddressController()
        {
            _adressfactory = new AddressFactory(BaseUrl, Account, Password);
        }


        [HttpGet("/Address")]
        public IActionResult Index()
        {
            return Ok(_adressfactory.GetAll());
        }

        [HttpGet("/numberofaddress")]
        public int NumberOfAddresses()
        {
            return _adressfactory.GetAll().Count();
        }

        [HttpGet("/address/{id}")]
        public IActionResult Address(int id)
        {
            var address = _adressfactory.Get(id);
            return Ok(address);
        }



        [HttpPost("/address")]
        public IActionResult NumberOfAddresses([FromBody]Bukimedia.PrestaSharp.Entities.address address)
        {
            _adressfactory.Add(address);
            return Ok(address);
        }

        [HttpPut("/address")]
        public IActionResult UpdateAddress([FromBody] Bukimedia.PrestaSharp.Entities.address address)
        {
            var adres = _adressfactory.Get((long)address.id);
            _adressfactory.Update(adres);
            return Ok(address);
        }

        





    }
}
