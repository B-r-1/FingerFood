using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.DataAccess {
    public interface IContext {
        Int32 SaveChanges();

        DbEntityEntry Entry(Object entity);

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Database Database { get; }
    }
}
