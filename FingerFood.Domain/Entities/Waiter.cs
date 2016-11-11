using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Domain.Entities
{
    public class Waiter
    {
        public Waiter()
        {
            this.TablesWaiters = new HashSet<TableWaiter>();
        }
        public Int64 Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Int32 Dni { get; set; }
        public String Turn { get; set; }
        public virtual ICollection<TableWaiter> TablesWaiters { get; set; }
    }
}
