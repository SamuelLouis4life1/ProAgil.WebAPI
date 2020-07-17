using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebAPI.Model;
using ProAgil.WebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContexts _contexts;
        public ValuesController(DataContexts context)
        {
            _contexts = context;
        }


        // GET api/values
        [HttpGet]
        public async Task <ActionResult> Get()
        {
            try
            {
                var results = await _contexts.Events.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Bank Failure");
                
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var results = await _contexts.Events.FirstOrDefaultAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Bank Failure");
                
            }
            //return new Event[] {
            //    new Event(){
            //        EventId = 1,
            //        Theme = "Angular and .NET CORE",
            //        Local = "Rio de Janeiro",
            //        Lot = "First Lot",
            //        QtyPeople = 250,
            //        EventDate = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //    },
            //    new Event(){
            //        EventId = 2,
            //        Theme = "Angular and others",
            //        Local = "São Paulo",
            //        Lot = "second Lot",
            //        QtyPeople = 290,
            //        EventDate = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
            //    }
            //}.FirstOrDefault(x => x.EventId == id);
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
