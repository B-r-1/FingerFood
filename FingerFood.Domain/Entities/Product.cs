using FingerFood.Base.Domain.Entities;
using FingerFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace FingerFood.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {
            //this.OrdersDetails = new HashSet<OrderDetail>();
        }

        public Int64 Id { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public String Description { get; set; }
        public Int64 IdCategory { get; set; }
        public String ImagePath { get; set; }
        public Int32 DisplayOrder { get; set; }

        [ForeignKey("IdCategory")]
        public virtual Category Category { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrderDetail> OrdersDetails { get; set; }
    }
}
