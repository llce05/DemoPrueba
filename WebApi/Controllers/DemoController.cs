using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DemoController : ApiController
    {
        DemoModel[] elements = new DemoModel []
        {
            new DemoModel { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new DemoModel { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new DemoModel { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public IEnumerable<DemoModel> GetAllDemos()
        {
            return elements;
        }
        [HttpGet]
        public IHttpActionResult GetDemo(int id)
        {
            var elemnt = elements.FirstOrDefault((p) => p.Id == id);
            if (elemnt == null)
            {
                return NotFound();
            }
            return Ok(elemnt);
        }
    }
}
