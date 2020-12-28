using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            // if user has a cart;
            var cart = GetCartByUserId(userId);

            if (cart != null)
            {
                // kullanici cart a ekledigi urunu daha once cart a eklemisse o urunun quantity sini arttiricaz. ayni urunu tekrar eklemiycek. quantity sini eklemek yeterli;
                var index = cart.CartItems.FindIndex(i => i.ProductId == productId);

                // index 0 veya 0 dan buyuk gelirse demekki o product zaten cart to var. 0 dan kucukse cart ta o product yok ve product i cart a atmamiz gerekiyor;
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem() 
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    // product data once eklenmis. kullanici tekrar ayni product i ekliyor. product cart imizda zaten oldugundan sadece quantity sini arttiricaz.
                    cart.CartItems[index].Quantity += quantity;
                }

                _cartDal.Update(cart);
            }
        }

        public void DeleteFromCart(string userId, int productId)
        {
            // Yapilacak islem CartItem tablosundan silinmek istenen urunu id si ile silmek. CartItem tablosu Cart tablosuna bagli ve Cart tablosu uzerinden calistigimiz icin Cart i aliyoruz.
            var cart = GetCartByUserId(userId);

            if (cart != null)
            {
                var cartId = cart.Id;

                _cartDal.DeleteFromCart(cartId, productId);
            }
        }

        public Cart GetCartByUserId(string userId)
        {
            return  _cartDal.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _cartDal.Create(new Entities.Cart() { UserId = userId });
        }
    }
}
