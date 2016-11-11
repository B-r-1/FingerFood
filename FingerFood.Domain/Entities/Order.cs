using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            this.OrdersDetails = new HashSet<OrderDetail>();
        }
        public Int64 Id { get; set; }
        public Int64 IdTable { get; set; }
        public Int64 OrderDate { get; set; }
        public bool Active { get; set; }
        public virtual Table Table { get; set; }
        public virtual ICollection<OrderDetail> OrdersDetails { get; set; }
    }
}
