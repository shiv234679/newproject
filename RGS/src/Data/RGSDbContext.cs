using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class RGSDbContext : DbContext
    {
        public RGSDbContext(DbContextOptions<RGSDbContext> options) : base(options)
        {

        }
        //DbSet of all Data Model
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
