using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.Entities.Abstract;

namespace Api.DataAccess.Abstract
{
    public interface IRepository<T, in TKey> where T : class, IEntity<TKey>, new() where TKey : IEquatable<TKey>
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        Task<T> Find(Expression<Func<T, bool>> predicate);
        Task<T> GetById(TKey id);
        Task<T> Add(T entity);
        Task<bool> AddRange(IEnumerable<T> entities);
        Task<T> Update(TKey id, T entity);
        Task<T> Update(T entity, Expression<Func<T, bool>> predicate);
        Task<T> Delete(T entity);
        Task<T> Delete(TKey id);
        Task<T> Delete(Expression<Func<T, bool>> filter);
    }
}