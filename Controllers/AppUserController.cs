using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUserController : ControllerBase
    {

        private readonly MyDatabaseContext db;

        public AppUserController( MyDatabaseContext _db){
            db = _db;
        }

        // GET: api/AppUser
        [HttpGet]
        public List<Appuser> Get()
        {
            return db.Appusers.ToList();
        }

        // GET: api/AppUser/5
        [HttpGet("{id}", Name = "Get")]
        public Appuser Get(int id)
        {
            return db.Appusers.Single(u => u.Id == id);
        }

        // POST: api/AppUser
        [HttpPost]
        public void Post([FromBody] Appuser user)
        {
            db.Appusers.Add(user);
            db.SaveChanges();
        }

        // PUT: api/AppUser/5
        [HttpPut]
        public void Put( [FromBody] Appuser user)
        {
            db.Appusers.Update(user);
            db.SaveChanges();
        }

        // DELETE: api/AppUser/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Appuser user = db.Appusers.Single(u=> u.Id == id);
            db.Appusers.Remove(user);
            db.SaveChanges();
        }
    }
}
