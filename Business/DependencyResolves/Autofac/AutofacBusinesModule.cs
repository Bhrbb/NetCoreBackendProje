
using Autofac;
using Business.Abstrack;
using Business.Abstrack.IProductServices;
using Business.Concrete;
using Business.Concrete.ProductManager;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWrok;


namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinesModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductServices>();
            builder.RegisterType<CategoryManager>().As<ICategoryServices>();
            builder.RegisterType<UserManager>().As<IUserServices>();
            //builder.RegisterType<IProductServices>().As<ProductManager>();
            //if somebody wants IProductServices e, you give them  ProductManager
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();



        }



    }
}
