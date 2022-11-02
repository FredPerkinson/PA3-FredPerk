using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Database;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/Driver
        [HttpGet]
        public List<Driver> Get()
        {
            ReadDriver readObject = new ReadDriver();/////////////////
            return readObject.readDriver(); /////////////////////////
        }

        // GET: api/Driver/5
        [HttpGet("{id}", Name = "Get")]
        public Driver Get(int id)
        { 
            ReadDriver readObject = new ReadDriver();
            return readObject.ViewDriver(id);
        }

        // POST: api/Driver
        [HttpPost]
        public void Post([FromBody]Driver driver)
        {
            CreateDriver myDriver = new CreateDriver();
            myDriver.createDriver(driver);
        }

        // PUT: api/Driver/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            EditDriver myDriver = new EditDriver();
            myDriver.UpdateDriver(myDriver);
        }

        // DELETE: api/Driver/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DeleteDriver myDriver = new DeleteDriver();
            myDriver.DeleteMyDriver(id);
        }
    }
}
