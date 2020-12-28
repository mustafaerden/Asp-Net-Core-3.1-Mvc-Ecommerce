using Azlan.Ecommerce.Entities;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Abstract
{
    public interface ICartService
    {
        // Register isleminde her kullaniciya ait bir Cart olusturuyoruz
        void InitializeCart(string userId);

        Cart GetCartByUserId(string userId);

        void AddToCart(string userId, int productId, int quantity);

        // Cart tan bir urunun silinmesi;
        void DeleteFromCart(string userId, int productId);
    }
}
