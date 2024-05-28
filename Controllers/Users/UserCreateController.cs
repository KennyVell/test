using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Services;

namespace test.Controllers.Users
{
    public class UserCreateController : ControllerBase
    {
        //inyeccion de dependencias
        private readonly IAuthRepository _authRepository;

        public UserCreateController(IAuthRepository authRepository){
            _authRepository = authRepository;
        }
        [HttpPost]
        [Route("api/Auth/create")]
        public async Task<IActionResult> Create([FromBody]User user){
            
            _authRepository.Add(user);
            return Ok();
        }
    }
}