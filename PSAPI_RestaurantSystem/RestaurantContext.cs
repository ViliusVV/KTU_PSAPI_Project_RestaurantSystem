﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSAPIRestaurantSystem.Models;

namespace PSAPIRestaurantSystem
{
    public class RestaurantContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuEntry> MenuEntries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedMeal> OrderedMeals { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TakeoutOrder> TakeoutOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<TableOccupancy> TableOccupancies { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options): base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(b => b.Admin)
            //    .WithOne(i => i.Employee)
            //    .HasForeignKey<Admin>(b => b.EmployeeId);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(b => b.Waiter)
            //    .WithOne(i => i.Employee)
            //    .HasForeignKey<Waiter>(b => b.EmployeeId);

            // Describes TableOccupancy relationships
            modelBuilder.Entity<TableOccupancy>()
                .HasOne(pt => pt.Table)
                .WithMany(p => p.TableOccupancies)
                .HasForeignKey(pt => pt.TableId);

            modelBuilder.Entity<TableOccupancy>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.TableOccupancies)
                .HasForeignKey(pt => pt.OrderId);

            modelBuilder.Entity<TableOccupancy>()
                .HasOne(pt => pt.Reservation)
                .WithMany(p => p.TableOccupancies)
                .HasForeignKey(pt => pt.ReservationId);
        }
    }
}
