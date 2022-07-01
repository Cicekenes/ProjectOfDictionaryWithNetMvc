using ProjectOfDictionaryWithNetMvc.Business.Concrete;
using ProjectOfDictionaryWithNetMvc.Business.ValidationRules;
using ProjectOfDictionaryWithNetMvc.Dal.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOfDictionaryWithNetMvc.Ui.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv= new ContactValidator();
        public ActionResult Index()
        {
            var contactsLists = cm.GetList();
            return View(contactsLists);
        }

        //Mesajların içeriğini okumak
        public ActionResult GetContactDetails(int id)
        {
            var GetByMessage=cm.GetByID(id);
            return View(GetByMessage);
        }

        public PartialViewResult ContactSidebar()
        {
            return PartialView();
        }
    }
}