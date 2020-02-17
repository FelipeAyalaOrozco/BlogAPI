using BlogAPI.Models;
using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class UserController : ControllerBase
        {
            
            private UserService _userService;

            private readonly ILogger<UserController> _logger;

            public UserController(ILogger<UserController> logger, UserService userService)
            {
                _userService = userService;
                _logger = logger;
            }

            [HttpGet]
            public List<UserModel> GetUsers()
            {
            return _userService.GetUsers();
            }

            [HttpGet("{id}", Name = "GetUser")]
            public string Get(int id)
            {
                return "value";
            }

            // POST: /User
            [HttpPost]
            public string Post([FromBody] UserModel user)
            {
                return _userService.AddUsers(user);
            }

            // PUT: api/User/5
            [HttpPut("{id}")]
            public string Put(int id, [FromBody] UserModel user)
            {
            return _userService.EditUsers(id, user);
            }
            
            [HttpDelete("{id}")]
            public string Delete(int id)
            {
                return _userService.DeleteUsers(id);
            }

    }

   

}
