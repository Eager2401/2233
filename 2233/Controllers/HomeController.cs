using _2233.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2233.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult QuanLi()
        {
            var DanhSach = new San().KhoiTaoSan();
            return View(DanhSach);
        }
        public ActionResult NguoiDung()
        {
            var DanhSach = new San().KhoiTaoSan();
            return View(DanhSach);
        }
        public ActionResult ThemSan()
        {
            return View();
        }
        public ActionResult ThueSan()
        {
            return View();
        }
        public ActionResult SuaSan()
        {
            return View();
        }
        public ActionResult DongTatCaSan()
        {
            return View();
        }
        //public ActionResult LuuSan(int soSan,int giaThue1Gio,string tinhTrang) 
        //{
        //    DanhSachSan.DachSachSan.Add(new San()
        //    {
        //        SoSan = soSan,
        //        GiaThue1Gio = giaThue1Gio,
        //        TinhTrang = tinhTrang
        //    }
        //     ); 
        //    return RedirectToAction("QuanLi");
        //}
    }
}