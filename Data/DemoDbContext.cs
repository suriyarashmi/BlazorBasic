using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlazorApp1.Data
{
    public class DemoDbContext : DbContext
    {

        public DemoDbContext(DbContextOptions<DemoDbContext> options) :base(options)
        { 

           
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order>Orders { get; set; }
    }
}
