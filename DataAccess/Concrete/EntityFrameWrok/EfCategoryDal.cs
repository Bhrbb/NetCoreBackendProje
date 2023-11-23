using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWrok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWrok
{
    public class EfCategoryDal: EfEntitiyRepositoryBase<Category, NorthwindContext>,ICategoryDal
    {
    }
}
