using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data.Services
{
    interface ICrud<T> : IDisposable where T : class
    {
        T GetById(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        bool Update(T model);
        T Save(T model);
        List<T> GetListById(Expression<Func<T, bool>> predicate);
    }
}