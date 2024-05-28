using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using test.Data;
using test.Models;

namespace test.Services
{
    public class AuthRepository : IAuthRepository
    {
        public readonly TestContext _context;
        public AuthRepository(TestContext context){
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            //return "resultado";
        }

        public string Login(User user)
        {
            var userLogin = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            if(userLogin == null){
                return "Login false";
                throw new Exception("Invalid Login");
            }

            return "Login true";
        }
    }
}