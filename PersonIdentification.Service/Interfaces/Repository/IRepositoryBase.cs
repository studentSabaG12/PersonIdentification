﻿using System.Linq.Expressions;

namespace PersonIdentification.Service.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
       T Get(params object[] id);
       IQueryable<T> Set(Expression<Func<T, bool>> predicate);
       IQueryable<T> Set();
       void Insert(T entity);
       void Update(T entity);
       void InsertOrUpdate(T entity);
       void Delete(T entity);
       void Delete(object id);

    }
}
