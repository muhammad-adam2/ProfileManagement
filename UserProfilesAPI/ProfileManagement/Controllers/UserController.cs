using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ProfileManagement.Models;

namespace ProfileManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/user
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<Users>> Get()
        {
            DataAccess da = new DataAccess();
            List<Users> a = new List<Users>();
            a = da.GetAllUsers();

            return a;
        }

        // GET api/user/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            Users user = new Users();
            DataAccess da = new DataAccess();
            user = da.GetCurrentUser(id);
            return user;
        }

        // POST api/user
        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody] NewUser value)
        {
            DataAccess da = new DataAccess();
            da.SaveUser(value);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users value)
        {
            DataAccess da = new DataAccess();
            da.UpdateUser(id, value);
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataAccess da = new DataAccess();
            da.DeleteUser(id);
        }

        // POST api/user/login
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Login info)
        {
            DataAccess da = new DataAccess();
            var user = await da.Authenticate(info.Username, info.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
    }

}
