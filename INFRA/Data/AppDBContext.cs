using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace INFRA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure connection string for the database
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // Example for PostgreSQL
            base.OnModelCreating(modelBuilder);
        }

