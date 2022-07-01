using ProjectOfDictionaryWithNetMvc.Business.Concrete;
using ProjectOfDictionaryWithNetMvc.Dal.Concrete;
using ProjectOfDictionaryWithNetMvc.Dal.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOfDictionaryWithNetMvc.Ui.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
       
        public ActionResult Index()
        {
            //Toplam Kategori Sayısı
            var numOfCat = cm.GetList().Count();
            ViewBag.categorySum = numOfCat;

            //Başlık tablosunda yazılım kategorisine ait başlık sayısı
            var softToHead = hm.GetList().Where(x => x.Category.CategoryName == "Yazılım").Count();
            ViewBag.softSum = softToHead;

            //Yazarların adında 'a' harfi geçenler için
            //Like komutu
            var aToWriter = from p in wm.GetList()
                            where p.WriterName.Contains("A")
                            select p;

            ViewBag.aWriter = aToWriter.Count();

            //En fazla başlığa sahip kategori

            //var catToMax = cm.GetList().Where(u => u.CategoryID == u.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault().ToString();


            //ViewBag.MaxCat = catToMax;

            //Kategoriler tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki fark
            var minusCat = cm.GetList().Count(x => x.CategoryStatus == true);
            var plusCat = cm.GetList().Count(x => x.CategoryStatus == false);

            ViewBag.Fark = minusCat-plusCat;

            return View();
        }
    }
}