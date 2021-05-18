using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace uniqueTest.Models
{
    public class uniqueTestContext : DbContext
    {
        public uniqueTestContext (DbContextOptions<uniqueTestContext> options)
            : base(options)
        {
        }

        public DbSet<uniqueTest.Models.Order> Order { get; set; }
    }
}
