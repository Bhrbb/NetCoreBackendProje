using Business.Abstrack;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWrok;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryServices
    {
        private ICategoryDal _categoryDal;//dataAccess katmanı ile baglantı 
        //Entititese bak sonra 
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetList()
        {
            return new SuccesDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
    }
}
