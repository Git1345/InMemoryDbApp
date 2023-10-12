﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InMemoryDbApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
