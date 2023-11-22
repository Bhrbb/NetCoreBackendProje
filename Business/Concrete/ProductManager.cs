
using Business.Abstrack;
using Business.Abstrack.IProductServices;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;



namespace Business.Concrete.ProductManager
{
    public class ProductManager : IProductServices
    {

        private IProductDal _productDal;
        public ProductManager(IProductDal productdal)
        {
            _productDal = productdal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
           _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);

        }

       

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccesDataResult<Product>(_productDal.Get(p => p.ProductID == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList(p=>p.CategoryID== categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
           return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
