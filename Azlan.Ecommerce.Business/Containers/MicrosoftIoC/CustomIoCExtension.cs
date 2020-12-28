using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Business.Concrete;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.DataAccess.Concrete.EfCore.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Azlan.Ecommerce.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfCoreGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfCoreProductDal>();

            services.AddScoped<IProductImageService, ProductImageManager>();
            services.AddScoped<IProductImageDal, EfCoreProductImageDal>();

            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
        }
    }
}
