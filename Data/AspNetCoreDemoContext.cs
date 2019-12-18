using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreDemo.Models;

namespace AspNetCoreDemo.Data
{
    public class AspNetCoreDemoContext : DbContext
    {
        public AspNetCoreDemoContext (DbContextOptions<AspNetCoreDemoContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreDemo.Models.Movie> Movie { get; set; }
    }
}
