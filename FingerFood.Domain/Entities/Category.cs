
using FingerFood.Base.Domain.Entities;
using FingerFood.Domain.Entities;
using System;
using System.Collections.Generic;
namespace FingerFood.Domain
{
    public class Category : EntityBase
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Status { get; set; }
        public Int32 DisplayOrder { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
