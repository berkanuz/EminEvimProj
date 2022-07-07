using Berkan.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Berkan.Data
{
    public class DAL : DbContext
    {
        public DAL(DbContextOptions<DAL> options) : base(options) { }
        public DbSet<CustomerList> CustomerLists { get; set; }
        public DbSet<CustomerItem> CustomerItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
