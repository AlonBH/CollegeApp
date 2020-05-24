using System;
using System.Collections.Generic;

namespace CollegeApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}