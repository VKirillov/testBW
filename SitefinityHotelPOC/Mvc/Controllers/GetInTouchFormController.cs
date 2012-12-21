using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "GetInTouchForm", Title = "GetInTouchForm", SectionName = "MvcWidgets")]
    public class GetInTouchFormController : Controller
    {
   
        public ActionResult Index()
        {
          
            return View("Default");
        }
    }
}