using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BG.Data.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly APDBCONX _db;
		internal DbSet<T> dbSet;

		public Repository(APDBCONX db)
		{
			_db = db;
			this.dbSet = db.Set<T>();
		}

		public void Add(T entity)
		{
			dbSet.Add(entity);
		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null, string? includeProperties = null)
		{
			IQueryable<T> query = dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (includeProperties != null)
			{
				//abc,,xyz -> abc xyz
				foreach (var includeProperty in includeProperties.Split(
					new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProperty);
				}
			}
			if (orderby != null)
			{
				return orderby(query).ToList();
			}
			return query.ToList();
		}

		public T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
		{
			IQueryable<T> query = dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (includeProperties != null)
			{
				//abc,,xyz -> abc xyz
				foreach (var includeProperty in includeProperties.Split(
					new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProperty);
				}
			}
			return query.FirstOrDefault();
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entity)
		{
			dbSet.RemoveRange(entity);
		}
	}
}