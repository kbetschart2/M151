using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KennyTest.Models;
using KennyTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KennyTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService usersService)
        {
            _userService = usersService;
        }

        [HttpPost("login")]
        public User Login([FromBody] AuthenticateRequest authenticateRequest)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Modelstate invalid");
            }

            return _userService.Authenticate(authenticateRequest.Username, authenticateRequest.Password);

        }
    }
}