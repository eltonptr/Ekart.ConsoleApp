using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EKart.App.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Navigation Property
        public List<ProductOrders> ProductOrders { get; set; }
    }
}