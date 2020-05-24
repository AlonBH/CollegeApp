using System.Data.Entity;
using System.Runtime.Serialization;
using CollegeApp.Models;

namespace CollegeApp.Data
{
    public class CollegeAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CollegeAppContext() : base("name=CollegeAppContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasMany(order => order.OrderProducts)
                .WithRequired(orderProduct => orderProduct.Order)
                .HasForeignKey(orderProduct => orderProduct.OrderId);

            modelBuilder.Entity<Product>().HasMany(product => product.OrderProducts)
                .WithRequired(orderProduct => orderProduct.Product)
                .HasForeignKey(orderProduct => orderProduct.ProductId);

            modelBuilder.Entity<Customer>().HasMany(customer => customer.Orders)
                .WithRequired(order => order.Customer)
                .HasForeignKey(order => order.CustomerId);

            // modelBuilder.Configurations.Add(FormatterConverter)
        }
    }
}
