using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cmorrisShoppingApp1.Models.CodeFirst
{
    public class Order
    {
        public int Id { get; set; }
        public bool Completed { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ApplicationUser Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}