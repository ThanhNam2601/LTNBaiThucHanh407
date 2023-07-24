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
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstwebMVC.Models.Student> Student { get; set; } = default!;

        public DbSet<FirstwebMVC.Models.Customer> Customer { get; set; } = default!;
    }
}
