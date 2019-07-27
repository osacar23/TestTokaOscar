using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data.Services
{
    public class Crud<T> : ICrud<T> where T : class
    {
        private DbSet<T> entities;
        private TestTokaDbContext ctx;
        public DbSet<T> Entities
        {
            get { return entities; }
        }

        public Crud(TestTokaDbContext ctx)
        {
            this.ctx = ctx;
            entities = ctx.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                    .Single(p => p.PropertyType == typeof(DbSet<T>))
                                    .GetValue(ctx) as DbSet<T>;
        }
        public void Dispose()
        {
            if (ctx != null)
            {
                ctx.Dispose();
                ctx = null;
            }
            GC.SuppressFinalize(this);
        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return entities.SingleOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return  entities.ToList();
        }

        public T Save(T entity)
        {
            Add(entity);
            Persist();
            return entity;
        }
        public void Add(T entity)
        {
            entities.Add(entity);
        }
        public bool Update(T model)
        {
            ctx.Entry(model).State = EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }
        public int Persist()
        {
            return ctx.SaveChanges();
        }

        public List<T> GetListById(Expression<Func<T, bool>> predicate)
        {
            return entities.ToList();
        }
    }
}
