using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace System.Database.Entity
{
    public class CyDbContext : DbContext
    {
        public CyDbContext()
        {
        }

        public CyDbContext(DbContextOptions<CyDbContext> options)
           : base(options)
        {
        }

        public DbSet<Department>? Departments { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<EmailHistory>? EmailHistories { get; set; }
        public DbSet<EmailRecipient>? EmailRecipients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=cy_emailSystem;User=root;Password=bang0501@b;",
                new MySqlServerVersion(new Version(8, 0, 21)));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentID);

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeID);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<EmailHistory>()
              .HasKey(eh => eh.EmailHistoryID);

            modelBuilder.Entity<EmailRecipient>()
                .HasKey(er => new { er.EmailHistoryID, er.EmployeeID });

            modelBuilder.Entity<EmailRecipient>()
              .HasOne(er => er.EmailHistory)
              .WithMany(eh => eh.Recipients)
              .HasForeignKey(er => er.EmailHistoryID);

            modelBuilder.Entity<EmailRecipient>()
                .HasOne(er => er.Employee)
                .WithMany(e => e.EmailRecipients)
                .HasForeignKey(er => er.EmployeeID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
