using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;database=laundryDB;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PrePaidPackage> PrePaidPackages { get; set; }
        public DbSet<HeaderDeposit> HeaderDeposits { get; set;}
        public DbSet<DetailDeposit> DetailDeposits { get; set; }
        public DbSet<VWEmployeeAndJob> VwEmployeeAndJob { get; set; }
        public DbSet<VWServiceUnitAndCategory> vWServiceUnitAndCategories { get; set; }
        public DbSet<VWServiceAndPackage> vWServiceAndPackages { get; set; }
        public DbSet<VWPrepaidPackageCustomerAndService> vWPrepaidPackageCustomerAndServices { get; set; }
        public DbSet<VWHeaderDepositCustomer> vWHeaderDepositCustomers { get; set; }
        public DbSet<VWDetailDepositAndTranscation> vWDetailDepositAndTranscations { get; set; }
        public DbSet<VWDetailDepositsAndService> vWDetailDepositsAndServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VWEmployeeAndJob>(e =>
            {
                e.ToView("VW_EmployeeAndJob");
            }
            );

            modelBuilder.Entity<VWServiceUnitAndCategory>(s =>
            {
                s.ToView("VW_ServiceUnitAndCategory");
            } 
            );
            modelBuilder.Entity<VWServiceAndPackage>(p =>
            {
                p.ToView("VW_ServiceAndPackage");
            });

            modelBuilder.Entity<VWPrepaidPackageCustomerAndService>(d =>
            {
                d.ToView("VW_PrepaidPackageCustomerAndService");
            });

            modelBuilder.Entity<VWHeaderDepositCustomer>(h => 
            {
                h.ToView("VW_HeaderDepositCustomer");
            });

            modelBuilder.Entity<VWDetailDepositAndTranscation>(d =>
            {
                d.ToView("VW_DetailDepositAndTransaction");
            });

            modelBuilder.Entity<VWDetailDepositsAndService>(d =>
            {
                d.ToView("VW_DetailDepositsAndService");
            });
        }

    }
}
