using Lab_03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_03 {
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }
    }
}
