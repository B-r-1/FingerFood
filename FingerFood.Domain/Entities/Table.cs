using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Domain.Entities
{
    public class Table
    {
        public Table()
        {
            this.Orders = new HashSet<Order>();
            this.TablesWaiters = new HashSet<TableWaiter>();
        }
        public Int64 Id { get; set; }
        public bool Active { get; set; }
        public Int32 NumberTable { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<TableWaiter> TablesWaiters { get; set; }
    }
}
