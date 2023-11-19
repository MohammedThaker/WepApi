using Domain.Models.Request;
using Microsoft.EntityFrameworkCore;


namespace Domain.Models
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PayDelivery> PayDelivery { get; set; }
        public DbSet<PaymentCash> PaymentCash { get; set; }


    }
}
