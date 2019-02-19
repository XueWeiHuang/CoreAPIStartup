using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        // GET api/values
        [HttpGet]
        public ActionResult<List<ObjectToSend>> Get()
        {
            return new List<ObjectToSend>{
                new ObjectToSend {Data1="value1", Data2="value 2" },
                new ObjectToSend{Data1="value 3", Data2="value4"}
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ObjectToSend> Get(int id)
        {
            return new ObjectToSend { Data1 = "this is from whatever", Data2 = "good start" };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
