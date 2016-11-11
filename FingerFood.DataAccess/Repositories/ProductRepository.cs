using FingerFood.Base.Data;
using FingerFood.Base.DataAccess;
using FingerFood.Base.Exceptions;
using FingerFood.Domain;
using FingerFood.Domain.Entities;
using FingerFood.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.DataAccess.Repositories
{
   public class ProductRepository : RepositoryBase<Product, IContext>, IProductRepository {
        public ProductRepository(IContext context, IExceptionMapper exceptionMapper) :
            base(context, exceptionMapper) { }
    
    
    }
}
