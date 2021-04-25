using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;

namespace DemoMvc.Data
{
    public class DemoMvcContext : DbContext
    {
        public DemoMvcContext (DbContextOptions<DemoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMvc.Models.Movie> Movie { get; set; }
    }
}
