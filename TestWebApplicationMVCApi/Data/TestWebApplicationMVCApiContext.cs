using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestWebApplicationMVCApi.Models;

namespace TestWebApplicationMVCApi.Data
{
    public class TestWebApplicationMVCApiContext : DbContext
    {
        public TestWebApplicationMVCApiContext (DbContextOptions<TestWebApplicationMVCApiContext> options)
            : base(options)
        {
        }

        public DbSet<TestWebApplicationMVCApi.Models.User> User { get; set; }

        public DbSet<TestWebApplicationMVCApi.Models.Movie> Movie { get; set; }
    }
}
