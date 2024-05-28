using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Data
{
    public class TestContext : DbContext
    {
        //Constructor del contexto
        public TestContext(DbContextOptions<TestContext> options) : base(options) {}
        
        //Registramos los modelos
        public DbSet<User> Users { get; set; }
    }
}