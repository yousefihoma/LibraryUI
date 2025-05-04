using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData.Repository
{
    public class RepositoryImp<TEntity>(LibraryContext db) : IBaseRepository<TEntity> where TEntity: class

    {
        
        public void Delete(TEntity entity)
        {
            
            db.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
