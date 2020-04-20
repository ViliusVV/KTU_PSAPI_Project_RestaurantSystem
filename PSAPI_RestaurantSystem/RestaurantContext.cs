using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSAPI_RestaurantSystem.Models;

namespace PSAPI_RestaurantSystem
{
    public class RestaurantContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Table> Tables { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options): base(options)
        {
        
        }
    }
}
