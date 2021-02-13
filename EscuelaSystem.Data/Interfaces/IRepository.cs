using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EscuelaSystem.Models;

namespace EscuelaSystemData.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {

        T GetbyId(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
