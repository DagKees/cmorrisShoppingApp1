using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cmorrisShoppingApp1.Models.CodeFirst;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace cmorrisShoppingApp1.Models
{
    public class Universal : Controller 
    {
        ApplicationDbContext db = new ApplicationDbContext();

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = db.Users.Find(User.Identity.GetUserId());
                ViewBag.FirstName = user.FirstName;
                ViewBag.LastName = user.LastName;
                ViewBag.FullName = user.FullName;

                ViewBag.CartItems = user.CartItems.ToList();

                ViewBag.TotalCartItems = user.CartItems.Sum(c => c.Count);

                //ViewBag.CartItems = db.CartItems.AsNoTracking().Where(c => c.CustomerId == user.Id).ToList().Count().ToString() + " Item(s)";
                //ViewBag.CartItems = db.CartItems.AsNoTracking().Where(c => c.CustomerId == user.Id);
                //ViewBag.ItemTypes = db.ItemTypes.AsNoTracking().OrderBy(t => t.TypeName).ToList();
                decimal count = 0;
                //foreach (var cartItem in user.CartItems)
                //{
                //    if (cartItem.Item.Onsale == true)
                //    {
                //        count += cartItem.Item.SalePrice.value * Convert.ToDecimal(cartItem.Count);
                //    }
                //    else
                //    {
                //        count += cartItem.Item.Price * Convert.ToDecimal(cartItem.Count);

                //    }

                //}
                ViewBag.CartItemsTotalCost = count;
            }
                base.OnActionExecuted(filterContext);
        }
    }
}