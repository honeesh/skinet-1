using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> ListAllAsync();
        IReadOnlyList <T> FindAsync(Expression<Func<T, bool>> query);
        T GetByID(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}