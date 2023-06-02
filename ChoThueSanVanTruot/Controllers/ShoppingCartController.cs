using ChoThueSanVanTruot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoThueSanVanTruot.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ProductModel db = new ProductModel();
            return View(db.FindAll().ToList());
        }

        public RedirectToRouteResult AddToCart(int ProductId)
        {
            ProductModel db = new ProductModel();
            if (Session["ShoppingCart"] == null) // Nếu giỏ hàng chưa được khởi tạo
            {
                Session["ShoppingCart"] = new List<CartItem>();  // Khởi tạo Session["giohang"] là 1 List<CartItem>
            }

            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;  // Gán qua biến giohang dễ code

            // Kiểm tra xem sản phẩm khách đang chọn đã có trong giỏ hàng chưa

            if (ShoppingCart.FirstOrDefault(m => m.Id == ProductId) == null) // ko co sp nay trong gio hang
            {
                CartItem prodouct = db.FindProduct(ProductId);  // tim sp theo sanPhamID

                CartItem newItem = new CartItem()
                {
                    Id = ProductId,
                    Name = prodouct.Name,
                    Amount = 1,
                    Photo = prodouct.Photo,
                    Price = prodouct.Price

                };  // Tạo ra 1 CartItem mới

                ShoppingCart.Add(newItem);  // Thêm CartItem vào giỏ 
            }
            else
            {
                // Nếu sản phẩm khách chọn đã có trong giỏ hàng thì không thêm vào giỏ nữa mà tăng số lượng lên.
                CartItem cardItem = ShoppingCart.FirstOrDefault(m => m.Id == ProductId);
                cardItem.Amount++;
            }

            // Action này sẽ chuyển hướng về trang chi tiết sp khi khách hàng đặt vào giỏ thành công. Bạn có thể chuyển về chính trang khách hàng vừa đứng bằng lệnh return Redirect(Request.UrlReferrer.ToString()); nếu muốn.
            return RedirectToAction("Index", "ShoppingCart");
        }


        public ActionResult Indexi()
        {
            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;
            return View(ShoppingCart);

        }

        public RedirectToRouteResult UpdateAmount(int ProductId, int newAmount)
        {
            // tìm carditem muon sua
            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;
            CartItem EditAmount = ShoppingCart.FirstOrDefault(m => m.Id == ProductId);
            if (EditAmount != null)
            {
                EditAmount.Amount = newAmount;
            }
            return RedirectToAction("Index");

        }

        public RedirectToRouteResult RemoveItem(int ProductId)
        {
            List<CartItem> shoppingCart = Session["ShoppingCart"] as List<CartItem>;
            CartItem DelItem = shoppingCart.FirstOrDefault(m => m.Id == ProductId);
            if (DelItem != null)
            {
                shoppingCart.Remove(DelItem);
            }
            return RedirectToAction("Index");
        }
    }
}