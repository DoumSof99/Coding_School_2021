using Coding_School.Model;
using Coding_SchoolApp.EF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SchoolApp.EF.Context {
    public class Coding_SchoolAppContext : DbContext {
         
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected Coding_SchoolAppContext() : base() {

        }

        public Coding_SchoolAppContext(DbContextOptions options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCoding_SchoolApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
