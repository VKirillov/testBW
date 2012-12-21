using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "BusinessAccountForm", Title = "BusinessAccountForm", SectionName = "MvcWidgets")]
    public class BusinessAccountFormController : Controller
    {
       
        public ActionResult Index()
        {
           
            return View("Default");
        }
    }
}