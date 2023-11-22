using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWrok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWrok
{
    public class EfProductDal : EfEntitiyRepositoryBase<Product,NorthwindContext>,IProductDal
    {
       
    }
}
