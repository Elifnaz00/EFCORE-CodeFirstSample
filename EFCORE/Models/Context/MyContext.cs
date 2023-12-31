﻿using EFCORE.Models.Configuration;
using EFCORE.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
        : base(options)
        {
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserProfileConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
           
        }

        public DbSet<AppUser> AppUsers { get; set; }    
        public DbSet<AppUserProfile> Profiles { get; set; }    
        public DbSet<Category> Categories { get; set; }    
        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderDetail> OrderDetails { get; set; }    
        public DbSet<Product> Products { get; set; }    
    }
}
