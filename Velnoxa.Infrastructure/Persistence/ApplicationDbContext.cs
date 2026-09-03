using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Velnoxa.Domain.Entities;
namespace Velnoxa.Infrastructure.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }

        public DbSet<User> Users=> Set<User>();

        public DbSet<Company> Companies => Set<Company>();

        public DbSet<Customer> Customers => Set<Customer>();

        public DbSet<WhatsAppccount> WhatsAppccounts {  get; set; }

    }
}
