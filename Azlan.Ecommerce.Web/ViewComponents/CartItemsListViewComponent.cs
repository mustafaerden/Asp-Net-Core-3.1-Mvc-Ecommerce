using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Entities;
using Azlan.Ecommerce.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.ViewComponents
{
    public class CartItemsListViewComponent : ViewComponent
    {
        private readonly ICartService _cartService;
        private readonly UserManager<AppUser> _userManager;
        public CartItemsListViewComponent(ICartService cartService, UserManager<AppUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
           
            var userId = _userManager.GetUserId(UserClaimsPrincipal);
            var cart = _cartService.GetCartByUserId(userId);

            return View(new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.Product.Id,
                    Name = i.Product.Name,
                    Price = (decimal)i.Product.Price,
                    ImageUrl = i.Product.ProductImages.Where(p => p.Id == i.Product.FeaturedImageId).Select(z => z.Url).FirstOrDefault(),
                    Quantity = i.Quantity
                }).ToList()
            });
            
        }
    }
}
