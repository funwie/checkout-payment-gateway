using CheckoutPaymentGateway.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckoutPaymentGateway.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Phone> Phonns { get; set; }
        public DbSet<ThreeDSEnrollment> ThreeDSEnrollments { get; set; }
        public DbSet<Risk> Risks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Payment>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Address>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Card>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Customer>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Merchant>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Phone>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<ThreeDSEnrollment>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });

            modelBuilder.Entity<Risk>(
                u =>
                {
                    u.Property("Id");
                    u.HasKey("Id");
                });
        }
    }
}
