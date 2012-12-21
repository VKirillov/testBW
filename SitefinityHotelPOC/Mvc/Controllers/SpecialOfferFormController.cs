using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "SpecialOfferForm", Title = "SpecialOfferForm", SectionName = "MvcWidgets")]
    public class SpecialOfferFormController : Controller
    {
        public ActionResult Index()
        {
            return View("Default");
        }
    }
}