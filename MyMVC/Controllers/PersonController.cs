using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return new Person[] { 
                new Person { Id = 1, UserName = "Dimitris", Password = "user1", Guid=  Guid.NewGuid() },
                new Person { Id = 2, UserName = "Giorgos", Password = "user2", Guid=  Guid.NewGuid() } };
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return new Person { Id = id, UserName = "Dimitris", Password = "user1", Guid=  Guid.NewGuid() };
        }

        // POST api/<PersonController>
        [HttpPost]
        public Person Post([FromBody] Person value)
        {
            return value;
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public Person Put(int id, [FromBody] Person value)
        {
            value.Id = id;
            return value;
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return id;
        }
    }
}
