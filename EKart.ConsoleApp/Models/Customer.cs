using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart.App.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name {  get; set; }
        public string? StreetName { get; set; }
        public string Address {  get; set; }
        public string City {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Navigation Property
        public List<Order> Orders { get; set; }

    }
}
