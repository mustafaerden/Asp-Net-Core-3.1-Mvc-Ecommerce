using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.DataAccess.Concrete.EfCore.Context;
using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.Repositories
{
    public class EfCoreCartDal : EfCoreGenericRepository<Cart>, ICartDal
    {  
        // EfGeneric teki Update metodu cart isleminde bizim isimize yaramiyodu. ancak bu sekilde update edersek cart a bagli olan CartItems tablosu da update edilir. oyuzden Efgeneric teki update metodunu override ettik;
        public override void Update(Cart entity)
        {
            using var context = new ApplicationDbContext();

            context.Carts.Update(entity);
            context.SaveChanges();
        }

        // Register isleminde her kullanici icin database de Cart olusturduk. Kullanici id ye gore ona ait olan Cart i cekiyoruz bu metot ile;
        public Cart GetByUserId(string userId)
        {
            using var context = new ApplicationDbContext();

            return context
                         .Carts
                         .Include(I => I.CartItems)
                         .ThenInclude(I => I.Product)
                         .ThenInclude(I => I.ProductImages)
                         .FirstOrDefault(I => I.UserId == userId);
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using var context = new ApplicationDbContext();

            var cmd = @"delete from CartItem where CartId=@p0 And ProductId=@p1";

            context.Database.ExecuteSqlRaw(cmd, cartId, productId);
        }
    }
}
