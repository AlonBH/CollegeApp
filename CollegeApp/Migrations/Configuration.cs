using CollegeApp.Models;

namespace CollegeApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CollegeApp.Data.CollegeAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CollegeApp.Data.CollegeAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                            new Product {Id = 1, Name = "Alcogel", Price = 14.90}, 
                                          new Product {Id = 2, Name = "Basic Mask", Price = 12.90}, 
                                          new Product {Id = 3, Name = "Professional Mask", Price = 29.90});
           
            context.Customers.AddOrUpdate(
                            new Customer {Id = 1, Name = "Alon Ben Haim", Address = "Livne 4, Or Yehuda", Email = "alon.b.h.672@gmail.com"},
                                          new Customer {Id = 2, Name = "Shai Safra", Address = "Tahun 1, Tel Aviv", Email = "shaisafra2@gmail.com"},
                                          new Customer {Id = 3, Name = "Idan Adar", Address = "Haim Zakai 2, Petah Tikva", Email = "idan0540@gmail.com"});
           
            context.Orders.AddOrUpdate(
                new Order {CustomerId = 1, Date = DateTime.Now});
           
            context.OrderProducts.AddOrUpdate(
                new OrderProduct(){OrderId = 1, ProductId = 1});

            
        }
    }
}
