using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PurePunjabi.Models.sitecore.templates.User_Defined.Pure_Punjabi;
using Glass.Mapper.Sc;
namespace PurePunjabi.Controllers
{
    public class PageController : Controller
    {
        public AboutUs AboutUsModel { get; set; }
        public ContactUs ContactUsModel { get; set; }
        public ActionResult AboutUs()
        {
            var context = new SitecoreContext();
            AboutUsModel = context.GetCurrentItem<AboutUs>();
            return View("~/Views/Content/AboutUs.cshtml", AboutUsModel);
        }
        public ActionResult ContactUs()
        {
            var context = new SitecoreContext();
            ContactUsModel=context.GetCurrentItem<ContactUs>();
            return View("~/Views/Content/ContactUs.cshtml",ContactUsModel);
               
        }
	}
}