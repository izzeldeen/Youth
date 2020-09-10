using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Measurment> Measurments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Status> Status { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "Admin", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = "User", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, NameAr = "الاردن", NameEn = "Jordan", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Measurment>().HasData(new Measurment { Id = 1, UnitAr = "كيلوجرام", UnitEn = "Kilogram", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Measurment>().HasData(new Measurment { Id = 2, UnitAr = "جرام", UnitEn = "gram", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Measurment>().HasData(new Measurment { Id = 3, UnitAr = "كبير", UnitEn = "Large", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Measurment>().HasData(new Measurment { Id = 4, UnitAr = "متوسط", UnitEn = "Medium", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Measurment>().HasData(new Measurment { Id = 5, UnitAr = "صغير", UnitEn = "Small", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 1, NameAr = "على الانتظار", NameEn = "Pending", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 2, NameAr = "تم القبول", NameEn = "Accepted", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 3, NameAr = "مرفوض", NameEn = "Removed", CreatedAt = DateTime.Now });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 4, NameAr = "ملغي", NameEn = "Canceled", CreatedAt = DateTime.Now });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=YoghurtDbV2;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=true;");
            // optionsBuilder.UseSqlServer(@"Data Source=198.38.83.200;Initial Catalog=hafelaty_db;User ID=hafelaty_sa;Password=P@ssw0rd;");
            //Add By izz
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-79MDV3E;Initial Catalog=YoghurtDbV2;Trusted_Connection=True;");
            //Trusted_Connection=True;MultipleActiveResultSets=true

        }
    }
}
