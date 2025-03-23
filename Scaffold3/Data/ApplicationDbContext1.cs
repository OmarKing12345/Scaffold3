using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scaffold3.Models;

namespace Scaffold3.Data
{
     public class ApplicationDbContext1 : DbContext
    {
        public DbSet<Category> Categories             { get; set; }
        public DbSet<Brand > Brands                   { get; set; }
        public DbSet<Customer> Customers              { get; set; }
        public DbSet< MasterContext> MasterContexts   { get; set; }
        public DbSet<Order> Orders                    { get; set; }
        public DbSet<Product> Products                { get; set; }
        public DbSet<Staff> Staff                     { get; set; }
        public DbSet<Store> stores                    { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Integrated Security=True;Initial Catalog=Scaffold3;TrustServerCertificate=True");
        }
    }
}
