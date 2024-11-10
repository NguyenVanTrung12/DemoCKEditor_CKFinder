using DemoSQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSQL.Controllers
{
    public class PhimController : Controller
    {
        private QUAN_LY_PHIMsContext ctx = new QUAN_LY_PHIMsContext();
        public IActionResult Index()
        {
            List<Phim> lstPhim = ctx.Phims.ToList();
            
            ViewBag.Phim = lstPhim;
            
            return View();
        }
        public IActionResult Themmoi()
        {
            //List<Phim> lstPhim = ctx.Phims.ToList();
            //ViewBag.Phim = lstPhim;
            return View();
        }
        public IActionResult Sua(string maphim) {
            Phim obj = ctx.Phims.First(p => p.Maphim == maphim);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Luu(Phim data)
        {
            ctx.Phims.Add(data);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Sua(Phim data)
        {
            ctx.Phims.Update(data);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Xoa(string maphim)
        {
            // Lấy ra dữ liệu cần xóa
            Phim obj = ctx.Phims.First(s => s.Maphim == maphim);
            // Xóa dữ liệu
            ctx.Phims.Remove(obj);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Select() {
            List<ChuDe> lstChude = ctx.ChuDes.ToList();
            ViewBag.ChuDes = lstChude;
            return View(); 
        }

        
    }
}
