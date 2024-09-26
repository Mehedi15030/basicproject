using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using basicproject.Models;

namespace basicproject.Data
{
    public class basicprojectContext : DbContext
    {
        public basicprojectContext (DbContextOptions<basicprojectContext> options)
            : base(options)
        {
        }

        public DbSet<basicproject.Models.Product> Product { get; set; } = default!;
    }
}
