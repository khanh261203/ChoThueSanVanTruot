using ChoThueSanVanTruot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoThueSanVanTruot.Controllers
{
    public class SanVanTruotController : Controller
    {
        // GET: SanVanTruot
        public ActionResult Index()
        {
            {
                ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
                // List<SanVanTruot> dsSanVanTruot = context.SanVanTruots.ToList();
                List<SanVanTruot> dsSanVanTruot = null;
                if (Request.QueryString.Count == 0)
                {
                    dsSanVanTruot = context.SanVanTruots.ToList();
                }
                else
                {
                    double min = double.Parse(Request.QueryString["txtMin"]);
                    double max = double.Parse(Request.QueryString["txtMax"]);
                    dsSanVanTruot = context.SanVanTruots.
                        Where(x => x.gia >= min && x.gia <= max).
                        ToList();
                }
                return View(dsSanVanTruot);
            }
        }

        //CHI TIẾT
        public ActionResult Details(int id)
        {
            ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
            SanVanTruot svt = context.SanVanTruots.FirstOrDefault(x => x.idsan == id);
            return View(svt);
        }

        //THÊM MỚI
        public ActionResult Create()

        {
            if (Request.Form.Count > 0)
            {
                ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
                SanVanTruot svt = new SanVanTruot();
                svt.idsan = int.Parse(Request.Form["idsan"]);
                svt.tensan = Request.Form["tensan"];
                svt.loaisan = Request.Form["loaisan"];
                svt.diachisan = Request.Form["diachisan"];
                svt.soluongtoida = int.Parse(Request.Form["soluongtoida"]);
                svt.gia = float.Parse(Request.Form["gia"]);
                svt.ngaytao = DateTime.Parse(Request.Form["ngaytao"]);
                HttpPostedFileBase file = Request.Files["hinh"];
                if(file != null)
                {
                    string serverPath = HttpContext.Server.MapPath("~/hinh");
                    string filePath = serverPath + "/" + file.FileName;
                    file.SaveAs(filePath);
                    svt.hinh = file.FileName;
                }
                svt.trangthai = Request.Form["trangthai"];
                context.SanVanTruots.InsertOnSubmit(svt);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
   


        //CẬP NHẬT
        public ActionResult Edit(int id)
        {
            ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
            SanVanTruot svt = context.SanVanTruots.FirstOrDefault(x => x.idsan == id);
            if (Request.Form.Count == 0)
            {
                return View(svt);
            }
            svt.idsan = int.Parse(Request.Form["idsan"]);
            svt.tensan = Request.Form["tensan"];
            svt.loaisan = Request.Form["loaisan"];
            svt.diachisan = Request.Form["diachisan"];
            svt.soluongtoida = int.Parse(Request.Form["soluongtoida"]);
            svt.gia = float.Parse(Request.Form["gia"]);
            svt.ngaytao = DateTime.Parse(Request.Form["ngaytao"]);
            svt.hinh = Request.Form["hinh"];
            svt.trangthai = Request.Form["trangthai"];
            context.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ChoThueSanVanTruotDataContext context = new ChoThueSanVanTruotDataContext();
            SanVanTruot svt = context.SanVanTruots.FirstOrDefault(x => x.idsan == id);
            if (svt != null)
            {
                context.SanVanTruots.DeleteOnSubmit(svt);
                context.SubmitChanges();
            }
            return RedirectToAction("index");
        }
    }
}