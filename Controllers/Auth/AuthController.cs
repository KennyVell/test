using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Services;

namespace test.Controllers.Auth
{
    public class AuthController : ControllerBase
    {
        //inyeccion de dependencias
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository){
            _authRepository = authRepository;
        }

        [HttpPost]
        [Route("api/Auth/login")]
        public async Task<IActionResult> Login([FromBody] User user){
            
            if(!ModelState.IsValid){
                return BadRequest(new {message="Invalid Login"});
            }

            var result = _authRepository.Login(user);
            
            if(result.Contains("true")){

                return Ok(result);
            }
            return BadRequest(new {message="Invalid Login"});
        }
    }
}