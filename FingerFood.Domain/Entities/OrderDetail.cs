using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Domain.Entities
{
    public class OrderDetail
    {
        public Int64 Id { get; set; }
        public Int64 IdOrder { get; set; }
        public Int64 IdProduct { get; set; }
        public Int32 Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
