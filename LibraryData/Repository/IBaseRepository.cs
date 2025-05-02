using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace LibraryData.Repository
{
  public  interface IBaseRepository
    {
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null,
    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
        { }
        public virtual TEntity GetById(object Id) { }
        public virtual void Insert(TEntity entity) { }
        public virtual void Delete(TEntity entity) { }
        public virtual void Delete(object Id) { }
    }
}
