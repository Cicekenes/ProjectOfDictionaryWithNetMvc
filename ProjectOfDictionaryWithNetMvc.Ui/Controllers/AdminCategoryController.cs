using FluentValidation.Results;
using ProjectOfDictionaryWithNetMvc.Business.Concrete;
using ProjectOfDictionaryWithNetMvc.Business.ValidationRules;
using ProjectOfDictionaryWithNetMvc.Dal.EntityFramework;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOfDictionaryWithNetMvc.Ui.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryLists = cm.GetList();
            return View(categoryLists);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results =categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            var categoryId = cm.GetById(id);
            cm.CategoryDelete(categoryId);
            return RedirectToAction("Index");
        }
       
        public ActionResult EditCategory(int id)
        {
            var categoryId=cm.GetById(id);
            return View(categoryId);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }

    }
}