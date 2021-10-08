using System.ComponentModel.DataAnnotations;

namespace EKart.App.Models
{
    public class ProductOrders
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        //Navigation Property
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}