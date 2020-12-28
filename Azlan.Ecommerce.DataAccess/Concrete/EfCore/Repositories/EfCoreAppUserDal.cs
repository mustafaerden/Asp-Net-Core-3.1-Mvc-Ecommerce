using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.Repositories
{
    public class EfCoreAppUserDal : EfCoreGenericRepository<AppUser>, IAppUserDal
    {
    }
}
