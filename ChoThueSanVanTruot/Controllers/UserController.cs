using ChoThueSanVanTruot.Models;
using System;
using System.Collections.Generic;
//using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoThueSanVanTruot.Controllers
{
     public class UserController : Controller
    {
         public ActionResult Logout()
         {
            Session["User"]=null;
             return RedirectToAction("Index", "Home");
         }
        public ActionResult Indexu()
        {
            {
                ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
                List<User> dsUser = context.Users.ToList();
               // List<SanVanTruot> dsSanVanTruot = null;
                return View(dsUser);
            }
        }

        public ActionResult DangKi()
        {
            if (Request.Form.Count > 0)
            {
                ChoThueSanVanTruotDataContext db = new ChoThueSanVanTruotDataContext();
                User u = new User();
                u.iduser = int.Parse(Request.Form["iduser"]);
                u.email = Request.Form["email"];
                u.diachi = Request.Form["diachi"];
                u.sdt = int.Parse(Request.Form["sdt"]);
                u.matkhau = Request.Form["matkhau"];
                db.Users.InsertOnSubmit(u);
                db.SubmitChanges();
                return RedirectToAction("DangNhap", "User");
        
            }
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(User u)
        {
            ChoThueSanVanTruotDataContext db = new ChoThueSanVanTruotDataContext();
            var data = db.Users.
                Where(x => x.email == u.email && x.matkhau == u.matkhau).FirstOrDefault();
            if (data != null)
            {
                Session["User"] = data;
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.LoginFail = "Đăng nhập thất bại vui lòng kiểm tra lại";
                return View("DangNhap");
            }
        }
    }
}