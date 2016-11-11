using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Domain.Entities
{
   public class TableWaiter
   {
       public Int64 Id { get; set; }
        public Int64 IdWaiter { get; set; }
        public Int64 IdTable { get; set; }
        public string Turn { get; set; }
        public virtual Table Table { get; set; }
        public virtual Waiter Waiter { get; set; }
    }
}
