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
    public class MedicineController : ControllerBase
    {
        DbConnect con;
        DAL dl;
        public MedicineController(DbConnect con)
        {
            this.con = con;
            dl = new DAL(con);
        }

        // GET: api/<MedicineController>
        [EnableCors]
        [HttpGet]
        public IEnumerable<Medicine> Get()
        {
            //List<Medicine> ls = new List<Medicine>();
            //ls.Add(new Medicine { Medicine_Name = "500 Lupin", Category_Name = "Antibiotic Capsule", Company_Name = "Lupin", Quantity = 30, MF_Date = "0", EXP_Date = "0", Price_Rs = 190, Category_Of_Medicine = "Pharmacy Medicine" });
            //return ls;
            List<Medicine> ls = dl.display();
            return ls;
        }

        // GET api/<MedicineController>/5
        
        [HttpGet("{id}")]
        public Medicine Get(int id)
        {
            Medicine obj = dl.Search(id);  // search not working 
            return obj;                               // Search by medicine name works
        }

        // POST api/<MedicineController>
        [HttpPost]
        public void Post([FromBody] Medicine value)
        {
            dl.Register(value);
        }

        // PUT api/<MedicineController>/5

        [HttpPut]
        public void Put([FromBody] Medicine value)
        {

            dl.Update(value);

        }


        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dl.Delete(id);
        }
    }
}

