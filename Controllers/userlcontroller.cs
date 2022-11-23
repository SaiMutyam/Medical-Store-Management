using GroupServer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupServer.Model;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupServer.Controllers
 {
[Route("api/[controller]")]
[ApiController]
public class userlController : ControllerBase
{
    DbConnect con;
    dall dl4;
    public userlController(DbConnect con)
    {
        this.con = con;
        dl4 = new dall(con);
    }
        // GET: api/<UserController>
        [EnableCors]
        [HttpGet]
    public IEnumerable<userl> Get()
    {
        List<userl> ls = dl4.display();
        return ls;
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public userl Get(int id)
    {
        userl obj = dl4.Search(id);    // search by id
        return (obj);
    }

    // POST api/<UserController>
    [HttpPost]
    public void Post([FromBody] userl value)
    {
        dl4.Register(value);    // adding new user
    }

    //..........................
    [HttpPost("LoginUser")]
    public IActionResult Login([FromBody] userl user)
    {
        if (user == null)
        {
            return BadRequest();
        }
        else
        {
            var useravailable = con.userls.Where(u => u.User_Name == user.User_Name && u.Password == user.Password).FirstOrDefault();
            if (useravailable == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "User Not Found !"
                });
            }
            else
            {
                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Logged In Successfully",
                    UserData = user.Name
                });
            }
        }

    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
