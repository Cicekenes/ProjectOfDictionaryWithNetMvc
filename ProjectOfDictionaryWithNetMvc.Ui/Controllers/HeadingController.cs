using ProjectOfDictionaryWithNetMvc.Business.Concrete;
using ProjectOfDictionaryWithNetMvc.Dal.EntityFramework;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOfDictionaryWithNetMvc.Ui.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingList = hm.GetList();
            return View(headingList);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            //Dropdownlist categories

            List<SelectListItem> categoriesLists = (from x in cm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();

            ViewBag.DdlCat = categoriesLists;

            //Dropdownlist writers
            List<SelectListItem> writerLists = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName + " " + x.WriterSurname,
                                                    Value = x.WriterID.ToString()
                                                }).ToList();
            ViewBag.DdlWriters = writerLists;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            //DateTime.Parse(DateTime.Now.ToShortDateString())
            DateTime dt = DateTime.Now;
            p.HeadingDate = DateTime.Parse(dt.ToString("g"));
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult ContentByHeading()
        {

            return View();
        }
        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> categoriesLists = (from x in cm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();

            ViewBag.DdlCat = categoriesLists;

            var headingValues = hm.GetById(id);
            return View(headingValues);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading heading)
        {
            hm.HeadingUpdate(heading);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);
            return RedirectToAction("Index");
        }
    }
}