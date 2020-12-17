using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Models;

namespace ManagementSystem.Data
{
    public class ManagementSystemContext : DbContext
    {
        public ManagementSystemContext(DbContextOptions<ManagementSystemContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasOne(x => x.Manager)
                .WithOne()
                .HasForeignKey<Employee>(y => y.ManagerId)
                .IsRequired(false);

            builder.Entity<Employee>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId);

            base.OnModelCreating(builder);
        }
    }
}
