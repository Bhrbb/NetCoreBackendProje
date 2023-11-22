
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstrack.IProductServices
{
    public interface IProductServices
    {

        IDataResult<Product> GetById(int productId);

        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);   





    }
}
