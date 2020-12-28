using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        { 
        }
    }
}
