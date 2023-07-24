using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstwebMVC.Models;
namespace FirstWebMVC.Data
{
    public class AppilicationDbContext : DbContext
    {
        public AppilicationDbContext (DbContextOptions<AppilicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
    }
}
