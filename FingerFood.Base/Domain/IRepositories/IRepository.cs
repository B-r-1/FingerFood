using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Domain.IRepositories
{
	public interface IRepository<T> where T : class {

		IQueryable<T> GetAll();

		IQueryable<T> GetAllAsNoTracking();

		IQueryable<T> Get();

		IQueryable<T> GetAsNoTracking();

		IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

		void Save(T entity);

		void Delete(List<Int64> keys);

		void MarkCollectionAsUnchanged(IEnumerable entities);
	}
}
