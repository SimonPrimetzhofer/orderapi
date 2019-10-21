using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Model
{
    public class OrderContext : DbContext 
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<Order> Orders { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Group> Groups { set; get; }
    }
}
