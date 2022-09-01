using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Controller;
using DatingApp.API.database;
using DatingApp.API.database.entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        public readonly DataContext _context;
        

        public UserController (DataContext context){
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_context.Users);
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id) 
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) {
                return NotFound();
            }
            return Ok(user);
        }
         
    }
}