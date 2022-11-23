using GroupServer.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        DbConnect con;
        DAL3 dl3;
        public AdminController(DbConnect con)
        {
            this.con = con;
            dl3 = new DAL3(con);
        }
        // GET: api/<EmployeeController>
        [EnableCors]
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            List<Admin> ls = dl3.display();
            return ls;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            Admin obj = dl3.Search(id);
            return obj;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Admin value)
        {
            dl3.Register(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public void Put([FromBody] Admin value)
        {
            dl3.Update(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dl3.Delete(id);
        }
    }
}
