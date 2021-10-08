using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EKart.App.Models
{
    public class Order
    {
        [Key]
        public int Id {  get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullfilled {  get; set; }
        public string PaymentMethod { get; set; }


        //Navigation Property
        public Customer Customer { get; set; }
        public List<ProductOrders> ProductOrders { get; set; }
    }
}