using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FingerFood.Base.Domain.IRepositories;
using FingerFood.Domain.Entities;

namespace FingerFood.Domain.IRepositories
{
    public interface IProductRepository : IRepository<Product>
    {
   }
}
