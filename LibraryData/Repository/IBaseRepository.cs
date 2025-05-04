using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LibraryData.Repository
{
  public  interface IBaseRepository<TEntity> where TEntity :class
    {
         IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? where =null,
    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "");
        TEntity GetById(object Id);
        void Insert(TEntity entity);
        void Delete(TEntity entity); 
        void Delete(object Id) { }
    }
}
