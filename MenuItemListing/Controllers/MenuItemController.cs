using MenuItemListing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController_cs : ControllerBase
    {
        List<MenuItem> list = new List<MenuItem>()
            {
                new MenuItem() {Id=101,Name="First",Price=500,Active=true,freeDelivery=false,dateOfLaunch=new DateTime(2020, 09, 23, 16, 45, 0) },
                new MenuItem() {Id=102,Name="Second",Price=100,Active=false,freeDelivery=false,dateOfLaunch=new DateTime(2021, 07, 25, 5, 31, 0) },
                new MenuItem() {Id=103,Name="Third",Price=650,Active=false,freeDelivery=true,dateOfLaunch=new DateTime(2019, 05, 31, 12, 15, 0) },
        };
        // GET: api/<MenuItemController_cs>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return list;
        }

        // GET api/<MenuItemController_cs>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return list.Find(m=>m.Id==id).Name;
        }

        // POST api/<MenuItemController_cs>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuItemController_cs>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuItemController_cs>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
