using Bai2.Models;
using Bai2.Models.Authentication;
using Bai2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Diagnostics;
using X.PagedList;

namespace Bai2.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authentication]
        public IActionResult Index(int? page)
        {
            //var lst = db.TDanhMucSps.ToList();
            //phân trang
            int pageNumber = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 8;
            var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        //home/sanphamtheoloai?maloai=vali(tui, balo,vi, ...)
        public IActionResult SanPhamTheoLoai(String Maloai, int? page)
        {
            int pageNumber = page == null || page < 1 ?1 :page.Value;
            int pageSize = 8;
            var lstSP = db.TDanhMucSps.Where(x => x.MaLoai == Maloai).AsNoTracking();
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstSP, pageNumber, pageSize);
            ViewBag.Maloai = Maloai;
           // List<TDanhMucSp> lstSP = db.TDanhMucSps.Where(x => x.MaLoai == Maloai).ToList();
            return View(lst);
        }

        public IActionResult ChiTietSanPham(string maSp)
        {

            var sanpham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var anhSanPham = db.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            ViewBag.anhSanPham = anhSanPham;
            if (sanpham == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(sanpham);
            }
        }

        public IActionResult ProductDetail(string maSp)
        {
            var sanpham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var anhSanPham = db.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            var HomeProdcutDetail = new HomeProductDetail { danhMucSp = sanpham, anhSps = anhSanPham };
            return View(HomeProdcutDetail);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}