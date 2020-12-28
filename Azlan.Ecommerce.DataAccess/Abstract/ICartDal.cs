using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Abstract
{
    public interface ICartDal : IGenericDal<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
    }
}
