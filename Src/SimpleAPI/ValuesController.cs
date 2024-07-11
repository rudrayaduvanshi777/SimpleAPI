using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI
{
    [ApiController]
    [Route("api/[controller]")]
   public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet("Getlist")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/values/5
        [HttpGet("GetID")]
        public string Get(int id)
        {
            return "zyz";
        }

        
    }
}