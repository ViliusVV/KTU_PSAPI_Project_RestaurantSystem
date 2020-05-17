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

            // People
            modelBuilder.Entity<Person>().HasData(
                new Person {PersonId = 1, Name = "Jonas", Surname = "Petraitis"},
                new Person { PersonId = 2, Name = "Mantas", Surname = "Jablonoskis" },
                new Person { PersonId = 3, Name = "Tomas", Surname = "Tomaitis" },
                new Person { PersonId = 4, Name = "Petras", Surname = "Petraitis" },
                new Person { PersonId = 5, Name = "Domas", Surname = "Domaitis" },
                new Person { PersonId = 6, Name = "Stasys", Surname = "Stasaitis" },
                new Person { PersonId = 7, Name = "Martyna", Surname = "Martynaitė" },
                new Person { PersonId = 8, Name = "Diana", Surname = "Jablonoskienė" },
                new Person { PersonId = 9, Name = "Tomas", Surname = "Petraitis" },
                new Person { PersonId = 10, Name = "Petras", Surname = "Stasaitis" }
            );

            // Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, PersonId = 1, Email = "jonas@emai.com", RegistrationDate = DateTime.Now, LastLoginDate = DateTime.Now,
                            LoyalityPoints = 1, Confirmed = true, Password = "slaptozodis" },
                new User
                {
                    UserId = 2,
                    PersonId = 2,
                    Email = "mantas@email.com",
                    RegistrationDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 10,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 3,
                    PersonId = 3,
                    Email = "tomas@email.com",
                    RegistrationDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 20,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 4,
                    PersonId = 4,
                    Email = "petraitis@gmail.com",
                    RegistrationDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 5,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 5,
                    PersonId = 5,
                    Email = "domas@email.com",
                    RegistrationDate = DateTime.Now.AddDays(-2),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 50,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 6,
                    PersonId = 6,
                    Email = "stasys@email.com",
                    RegistrationDate = DateTime.Now.AddDays(-3),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 60,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 7,
                    PersonId = 7,
                    Email = "martyna@email.com",
                    RegistrationDate = DateTime.Now.AddDays(-4),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 70,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 8,
                    PersonId = 8,
                    Email = "diana@email.com",
                    RegistrationDate = DateTime.Now.AddDays(-5),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 80,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 9,
                    PersonId = 9,
                    Email = "tomas@gmail.com",
                    RegistrationDate = DateTime.Now.AddDays(-6),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 3,
                    Confirmed = true,
                    Password = "slaptozodis"
                },
                new User
                {
                    UserId = 10,
                    PersonId = 10,
                    Email = "petras@gmail.com",
                    RegistrationDate = DateTime.Now.AddDays(-1),
                    LastLoginDate = DateTime.Now,
                    LoyalityPoints = 4,
                    Confirmed = true,
                    Password = "slaptozodis"
                }
            );

            // Reviews

            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, UserId = 1, Rating = 2, ReviewDate = DateTime.Now, ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum." },
                new Review { ReviewId = 2, UserId = 2, Rating = 5, ReviewDate = DateTime.Now, ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum." },
                new Review { ReviewId = 3, UserId = 3, Rating = 4, ReviewDate = DateTime.Now, ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum." }
                );

            // Employees

            modelBuilder.Entity<Employee>().HasData(
                new Employee {EmployeeId = 1, UserId = 1, EmployeeState = (int)WorkState.Working, BeganWork = DateTime.Now, Salary = 1000},
                new Employee { EmployeeId = 2, UserId = 2, EmployeeState = (int)WorkState.Working, BeganWork = DateTime.Now, Salary = 3000 },
                new Employee { EmployeeId = 3, UserId = 9, EmployeeState = (int)WorkState.Working, BeganWork = DateTime.Now, Salary = 2000 },
                new Employee { EmployeeId = 4, UserId = 10, EmployeeState = (int)WorkState.Working, BeganWork = DateTime.Now, Salary = 1500 }
                );

            // Admins

            modelBuilder.Entity<Admin>().HasData(
                new Admin { AdminId = 1, EmployeeId = 1, WorkEmail = "workmail@mymail.com"}
                );
            // Waiters

            modelBuilder.Entity<Waiter>().HasData(
                new Waiter { WaiterId = 1, EmployeeId = 2, Tips = 100 },
                new Waiter { WaiterId = 2, EmployeeId = 3, Tips = 200 },
                new Waiter { WaiterId = 3, EmployeeId = 4, Tips = 250 }
                );

            // reservations

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(24), State = (int)ReservationState.Done, ReservedByUserId = 1 },
                new Reservation { ReservationId = 2, PeopleCount = 1, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(48), State = (int)ReservationState.Canceled, ReservedByUserId = 1 },
                new Reservation { ReservationId = 3, PeopleCount = 3, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(60), State = (int)ReservationState.Active, ReservedByUserId = 1, Comment = "Atsivesiu suni" },
                new Reservation { ReservationId = 4, PeopleCount = 4, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(80), State = (int)ReservationState.Canceled, ReservedByUserId = 1 },
                new Reservation { ReservationId = 5, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(100), State = (int)ReservationState.Active, ReservedByUserId = 1 },
                new Reservation { ReservationId = 6, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(120), State = (int)ReservationState.Done, ReservedByUserId = 1 },
                new Reservation { ReservationId = 7, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(160), State = (int)ReservationState.Canceled, ReservedByUserId = 1 },
                new Reservation { ReservationId = 8, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(180), State = (int)ReservationState.Active, ReservedByUserId = 1 },
                new Reservation { ReservationId = 9, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(24), State = (int)ReservationState.Done, ReservedByUserId = 5 },
                new Reservation { ReservationId = 10, PeopleCount = 1, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(48), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 11, PeopleCount = 3, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(60), State = (int)ReservationState.Active, ReservedByUserId = 5, Comment = "Atsivesiu kate" },
                new Reservation { ReservationId = 12, PeopleCount = 4, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(80), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 13, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(100), State = (int)ReservationState.Active, ReservedByUserId = 5 },
                new Reservation { ReservationId = 14, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(120), State = (int)ReservationState.Done, ReservedByUserId = 5 },
                new Reservation { ReservationId = 15, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(160), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 16, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(180), State = (int)ReservationState.Active, ReservedByUserId = 5 },
                new Reservation { ReservationId = 17, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(24), State = (int)ReservationState.Done, ReservedByUserId = 6 },
                new Reservation { ReservationId = 18, PeopleCount = 1, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(48), State = (int)ReservationState.Canceled, ReservedByUserId = 6 },
                new Reservation { ReservationId = 19, PeopleCount = 3, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(60), State = (int)ReservationState.Active, ReservedByUserId = 6, Comment = "Atsivesiu suni" },
                new Reservation { ReservationId = 20, PeopleCount = 4, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(80), State = (int)ReservationState.Canceled, ReservedByUserId = 6 },
                new Reservation { ReservationId = 21, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(100), State = (int)ReservationState.Active, ReservedByUserId = 6 },
                new Reservation { ReservationId = 22, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(120), State = (int)ReservationState.Done, ReservedByUserId = 6 },
                new Reservation { ReservationId = 23, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(160), State = (int)ReservationState.Canceled, ReservedByUserId = 6 },
                new Reservation { ReservationId = 24, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(180), State = (int)ReservationState.Active, ReservedByUserId = 6 },
                new Reservation { ReservationId = 25, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(24), State = (int)ReservationState.Done, ReservedByUserId = 7 },
                new Reservation { ReservationId = 26, PeopleCount = 1, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(48), State = (int)ReservationState.Canceled, ReservedByUserId = 7 },
                new Reservation { ReservationId = 27, PeopleCount = 3, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(60), State = (int)ReservationState.Active, ReservedByUserId = 7, Comment = "Atsinesiu vezliuka" },
                new Reservation { ReservationId = 28, PeopleCount = 4, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(80), State = (int)ReservationState.Canceled, ReservedByUserId = 7 },
                new Reservation { ReservationId = 29, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(100), State = (int)ReservationState.Active, ReservedByUserId = 7 },
                new Reservation { ReservationId = 30, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(120), State = (int)ReservationState.Done, ReservedByUserId = 7 },
                new Reservation { ReservationId = 31, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(160), State = (int)ReservationState.Canceled, ReservedByUserId = 7 },
                new Reservation { ReservationId = 32, PeopleCount = 2, ReservedDate = DateTime.Now, ReservedForDate = DateTime.Now.AddHours(180), State = (int)ReservationState.Active, ReservedByUserId = 7 },

                new Reservation { ReservationId = 33, PeopleCount = 2, ReservedDate = DateTime.Now.AddHours(-48), ReservedForDate = DateTime.Now.AddHours(-24), State = (int)ReservationState.Done, ReservedByUserId = 5 },
                new Reservation { ReservationId = 34, PeopleCount = 1, ReservedDate = DateTime.Now.AddHours(-60), ReservedForDate = DateTime.Now.AddHours(-48), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 35, PeopleCount = 3, ReservedDate = DateTime.Now.AddHours(-80), ReservedForDate = DateTime.Now.AddHours(-60), State = (int)ReservationState.Active, ReservedByUserId = 5, Comment = "Atsivesiu suni" },
                new Reservation { ReservationId = 36, PeopleCount = 4, ReservedDate = DateTime.Now.AddHours(-100), ReservedForDate = DateTime.Now.AddHours(-80), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 37, PeopleCount = 2, ReservedDate = DateTime.Now.AddHours(-120), ReservedForDate = DateTime.Now.AddHours(-100), State = (int)ReservationState.Active, ReservedByUserId = 5 },
                new Reservation { ReservationId = 38, PeopleCount = 2, ReservedDate = DateTime.Now.AddHours(-160), ReservedForDate = DateTime.Now.AddHours(-120), State = (int)ReservationState.Done, ReservedByUserId = 5 },
                new Reservation { ReservationId = 39, PeopleCount = 2, ReservedDate = DateTime.Now.AddHours(-180), ReservedForDate = DateTime.Now.AddHours(-160), State = (int)ReservationState.Canceled, ReservedByUserId = 5 },
                new Reservation { ReservationId = 40, PeopleCount = 2, ReservedDate = DateTime.Now.AddHours(-200), ReservedForDate = DateTime.Now.AddHours(-180), State = (int)ReservationState.Active, ReservedByUserId = 5 }
                );

            // orders

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderNum = 1, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 2, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 3, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 4, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 5, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 6, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 7, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 8, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 9, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 10, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 11, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 12, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 13, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 14, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 15, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 16, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 17, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 18, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 19, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 20, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 21, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 22, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 23, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 24, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 25, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 26, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 27, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 28, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 29, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 30, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 31, State = (int)OrderState.Created, ManagedByWaiterId = null },
                new Order { OrderNum = 32, State = (int)OrderState.Created, ManagedByWaiterId = null },

                new Order { OrderNum = 33, State = (int)OrderState.Submitted, ManagedByWaiterId = 1, Price = 10, Duration = 45 },
                new Order { OrderNum = 34, State = (int)OrderState.Canceled, ManagedByWaiterId = 1 },
                new Order { OrderNum = 35, State = (int)OrderState.Submitted, ManagedByWaiterId = 2, Price = 11, Duration = 51 },
                new Order { OrderNum = 36, State = (int)OrderState.Canceled, ManagedByWaiterId = 3 },
                new Order { OrderNum = 37, State = (int)OrderState.Submitted, ManagedByWaiterId = 2, Price = 20, Duration = 30 },
                new Order { OrderNum = 38, State = (int)OrderState.Submitted, ManagedByWaiterId = 1, Price = 40, Duration = 37 },
                new Order { OrderNum = 39, State = (int)OrderState.Canceled, ManagedByWaiterId = 3 },
                new Order { OrderNum = 40, State = (int)OrderState.Submitted, ManagedByWaiterId = 2, Price = 65, Duration = 153 }
                );

            // Table occupancies

            modelBuilder.Entity<TableOccupancy>().HasData(
                new TableOccupancy { TableOccupancyId = 1, OrderId = 33, ReservationId = 33, TableId = 2 },
                new TableOccupancy { TableOccupancyId = 2, OrderId = 33, ReservationId = 33, TableId = 10 },
                new TableOccupancy { TableOccupancyId = 3, OrderId = 33, ReservationId = 33, TableId = 4 },

                new TableOccupancy { TableOccupancyId = 4, OrderId = 35, ReservationId = 35, TableId = 11 },
                new TableOccupancy { TableOccupancyId = 5, OrderId = 37, ReservationId = 37, TableId = 12 },
                new TableOccupancy { TableOccupancyId = 6, OrderId = 38, ReservationId = 38, TableId = 11 },
                new TableOccupancy { TableOccupancyId = 7, OrderId = 40, ReservationId = 40, TableId = 12 }
                );

        }
    }
}
