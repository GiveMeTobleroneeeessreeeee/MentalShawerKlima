using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SensorLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMentalShowerIndoor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        public static List<Sensor> målinger = new List<Sensor>()
        {
            new Sensor(1,"D3.05", 24, 35, 700, 0),
            new Sensor(2,"D3.06", 22, 54, 700, 0),
            new Sensor(3,"D3.07", 23, 34, 700, 0),
            new Sensor(4,"D3.08", 19, 39, 700, 0),
            new Sensor(5,"D3.09", 20, 67, 700, 0),
            new Sensor(6,"D3.10", 7, 35, 700, 0),


        };

        // GET: api/<SensorController>
        [HttpGet]
        public IEnumerable<Sensor> Get()
        {
            return målinger;
        }

        // GET api/<SensorController>/5
        [HttpGet("{id}")]
        public Sensor Get(string id)
        {

            return målinger.Find(i => i.LokaleId == id);
        }



        //// POST api/<SensorController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SensorController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SensorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
