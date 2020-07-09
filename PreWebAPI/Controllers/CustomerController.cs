using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bukimedia.PrestaSharp.Factories;
using Microsoft.AspNetCore.Mvc;

namespace PrestaDeneme.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerFactory _customerfactory; // hazır kütüphaneden çekiyor. 
        string BaseUrl = "http://localhost/prestashop/api";
        string Account = "V7UIRUC73SBY9ZNAI3GAIN3FKY17E8PV";
        string Password = "";

        public CustomerController()
        {
            _customerfactory = new CustomerFactory(BaseUrl, Account, Password); //kütüphanenin inputları
        }
        [HttpGet("/customer")]
        public IActionResult Index()
        {
            return Ok(_customerfactory.GetAll());
        }

        [HttpGet("/customer/{id}")]
        public IActionResult Customer(int id)
        {
            var customer = _customerfactory.Get(id);

            return Ok(customer);
        }

        [HttpGet("/numberofcustomers")]
        public int NumberOfCustomers()
        {
            
            
             
            return _customerfactory.GetAll().Count();
            
            
        }

        // yeni customer ekleme
        [HttpPost("/addcustomer")]
        public IActionResult AddCustomer([FromBody]Bukimedia.PrestaSharp.Entities.customer customer) //hazır model
        {
            _customerfactory.Add(customer);
            return Ok(customer);
        } 

        [HttpPut("/updatecustomer")]
        public IActionResult UpdateCustomer([FromBody] Bukimedia.PrestaSharp.Entities.customer customer)
        {
            var musteri = _customerfactory.Get((long)customer.id);
            _customerfactory.Update(customer);
            return Ok(customer);
        }


        [HttpDelete("/deletecustomer/{id}")]
        public IActionResult DeleteCustomer(long id)
        {
            var musteri = _customerfactory.Get(id);
            _customerfactory.Delete(musteri);
            return Ok();
        }
    }
}
