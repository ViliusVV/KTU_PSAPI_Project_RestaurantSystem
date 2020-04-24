using Microsoft.EntityFrameworkCore;
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
                .HasForeignKey(pt => pt.ReservationId)
                .IsRequired(false);

            // Seed initial data
            // Tables
            modelBuilder.Entity<Table>().HasData(
                    new Table { TableNum = 1, SeatCount = 4},
                    new Table { TableNum = 2, SeatCount = 2 },
                    new Table { TableNum = 3, SeatCount = 4 },
                    new Table { TableNum = 4, SeatCount = 5 },
                    new Table { TableNum = 5, SeatCount = 12 },
                    new Table { TableNum = 6, SeatCount = 12 },
                    new Table { TableNum = 7, SeatCount = 4 },
                    new Table { TableNum = 8, SeatCount = 4 },
                    new Table { TableNum = 9, SeatCount = 2 },
                    new Table { TableNum = 10, SeatCount = 2 },
                    new Table { TableNum = 11, SeatCount = 6 },
                    new Table { TableNum = 12, SeatCount = 6 }
                );

            // Menu
            modelBuilder.Entity<Menu>().HasData(
                    new Menu { MenuId = 1, Title = "Sriubos", Changed = DateTime.Now },
                    new Menu { MenuId = 2, Title = "Užkandžiai", Changed = DateTime.Now },
                    new Menu { MenuId = 3, Title = "Salotos", Changed = DateTime.Now },
                    new Menu { MenuId = 4, Title = "Kiauliena", Changed = DateTime.Now },
                    new Menu { MenuId = 5, Title = "Vistiena", Changed = DateTime.Now },
                    new Menu { MenuId = 6, Title = "Zuvis", Changed = DateTime.Now },
                    new Menu { MenuId = 7, Title = "Miltiniai patiekalai", Changed = DateTime.Now },
                    new Menu { MenuId = 8, Title = "Gaivieji gėrimai", Changed = DateTime.Now },
                    new Menu { MenuId = 9, Title = "Alus", Changed = DateTime.Now },
                    new Menu { MenuId = 10, Title = "Šampanas", Changed = DateTime.Now },
                    new Menu { MenuId = 11, Title = "Konjakas", Changed = DateTime.Now },
                    new Menu { MenuId = 12, Title = "Degtinė", Changed = DateTime.Now },
                    new Menu { MenuId = 13, Title = "Brendis", Changed = DateTime.Now },
                    new Menu { MenuId = 14, Title = "Vynas", Changed = DateTime.Now },
                    new Menu { MenuId = 15, Title = "Sidras", Changed = DateTime.Now },
                    new Menu { MenuId = 16, Title = "Burbonas", Changed = DateTime.Now },
                    new Menu { MenuId = 17, Title = "Džinas", Changed = DateTime.Now },
                    new Menu { MenuId = 18, Title = "Viskis", Changed = DateTime.Now }
                );

            // Menu entries
            modelBuilder.Entity<MenuEntry>().HasData(
                    // Sriubos id 1
                    new MenuEntry { MenuEntryId = 1, MenuId = 1, MenuEntryName = "Dienos sriuba", Price = 1.20, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 2, MenuId = 1, MenuEntryName = "Čili", Price = 3.00 ,Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 3, MenuId = 1, MenuEntryName = "Cibulynė", Price = 2.00, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 4, MenuId = 1, MenuEntryName = "Šaltibarščiai", Price = 2.50, Changed = DateTime.Now },
                    // Salotos id 2
                    new MenuEntry { MenuEntryId = 5, MenuId = 3, MenuEntryName = "Šviežių daržovių salotos", Price = 3.00, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 6, MenuId = 3, MenuEntryName = "Sveikuolių salotos ", Price = 3.50, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 7, MenuId = 3, MenuEntryName = "Vištienos salotos", Price = 3.50, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 8, MenuId = 3, MenuEntryName = "Graikiškos salotos ", Price = 4.50, Changed = DateTime.Now },
                    new MenuEntry { MenuEntryId = 9, MenuId = 3, MenuEntryName = "Burokėlių salotos su fetos sūriu ", Price = 4.50, Changed = DateTime.Now }

                    );
        }
    }
}
