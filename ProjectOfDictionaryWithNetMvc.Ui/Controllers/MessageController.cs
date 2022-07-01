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
    public class MessageController : Controller
    {
        MessageManager messagee = new MessageManager(new EfMessageDal());
        MessageValidator validator = new MessageValidator();
        //Gelen mesajlar
        public ActionResult Inbox()
        {
            var messageList = messagee.GetListInbox();
            return View(messageList);
        }

        public ActionResult Sendbox()
        {
            var messageLists = messagee.GetListSendbox();
            return View(messageLists);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var GetByMessage = messagee.GetById(id);
            return View(GetByMessage);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var GetByMessage = messagee.GetById(id);
            return View(GetByMessage);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            ValidationResult results= validator.Validate(message);
            if (results.IsValid)
            {
                message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString().ToString());
                messagee.MessageAdd(message);
            }else
            {
                foreach (var item in results.Errors)
                {
                    
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}