using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/Driver
        [HttpGet]
        public IEnumerable<string> Get()
        {
            ReadDriver readObject = new ReadDriver();/////////////////
            return readObject.readDriver(); /////////////////////////
        }

        // GET: api/Driver/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Driver
        [HttpPost]
        public void Post([FromBody]Driver driver)
        {
            CreateDriver myDriver = new CreateDriver();
            myDriver.Create(driver);
        }

        // PUT: api/Driver/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/Driver/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DeleteDriver myDriver = new DeleteDriver();
            myDriver.Delete(id);
        }
    }
}