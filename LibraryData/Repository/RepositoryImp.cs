using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData.Repository
{
   public class RepositoryImp
    {
        public class GenericRepositoryLibrary<TEntity> where TEntity : class
        {
            private Library1Entities _db;

            private DbSet<TEntity> _dbSet;
            public GenericRepositoryLibrary(Library1Entities db)
            {
                _db = db;
                _dbSet = _db.Set<TEntity>();
            }
            public virtual IQueryable<TEntity> GetAllAsQueryable() => _dbSet.AsQueryable();
            public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
            {
                IQueryable<TEntity> query = _dbSet;

                if (where != null)
                {
                    query = query.Where(where);
                }

                if (orderby != null)
                {
                    query = orderby(query);
                }

                if (includes != "")
                {
                    foreach (string include in includes.Split(','))
                    {

                        query = query.Include(include);
                    }
                }

                return query.ToList();
            }

            public virtual TEntity GetById(object Id)
            {
                return _dbSet.Find(Id);
            }
            public virtual void Insert(TEntity entity)
            {
                if (entity.GetType() == typeof(Members))
                {
                    var nationalCode = entity.GetType().GetProperty(nameof(Members.NationalCode)).GetValue(entity, null).ToString();
                    if (_db.Set<Members>().Any(r => r.NationalCode.Trim() == nationalCode.Trim()))
                    {
                        throw new Exception("کد ملی تکراری است");
                    }
                }
                _dbSet.Add(entity);

            }
            public virtual void Update(TEntity entity)
            {
               _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
                _db.Entry(entity).State = EntityState.Detached;
            }
            public virtual void Delete(TEntity entity)
            {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _dbSet.Remove(entity);

            }
            public virtual void Delete(object Id)
            {
                var entity = GetById(Id);

                Delete(entity);

            }

        }
    }
}
