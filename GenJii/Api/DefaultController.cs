using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenJii.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: api/Default
        [HttpGet]
        public object Get()
        {
            List<MyClass> myClasses = new List<MyClass>();
            for (int i = 0; i < 5; i++)
            {
                myClasses.Add(new MyClass() { ID = i, Name = $"xucheng{i}" });
            }
            return myClasses;
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"My Name is xuchengyi.How are you !You input id: {id}. Now Time is {DateTime.Now}";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    class MyClass
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
