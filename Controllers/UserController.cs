/*using GroupServer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupServer.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DbConnect con;
        DAL2 dl2;
        public UserController(DbConnect con)
        {
            this.con = con;
            dl2 = new DAL2(con);
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> ls = dl2.display();
            return ls;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User obj = dl2.Search(id);    // search by id
            return (obj);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            dl2.Register(value);    // adding new user
        }

        //..........................
        [HttpPost("LoginUser")]
        public IActionResult Login([FromBody]User user)
        {
            if(user ==null)
            {
                return BadRequest();
            }
            else
            {
                var useravailable = con.users.Where(u => u.User_Name == user.User_Name && u.Password == user.Password).FirstOrDefault();
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
                    }) ;
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
}*/
