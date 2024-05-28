using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Services
{
    public interface IAuthRepository
    {
        //Como se comporta el servicio
        string Login(User user);
        void Add(User user);
    }
}