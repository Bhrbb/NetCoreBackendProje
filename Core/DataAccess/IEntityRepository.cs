using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
        // ** this interface is ageneric type and that have terms for example T should be class
        // ** this must be IEntity type  or this take itself IEntity inherit 
        //** this must be new so you dont post the  interface here 

    {
    

        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter=null);

        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);




    }
}
