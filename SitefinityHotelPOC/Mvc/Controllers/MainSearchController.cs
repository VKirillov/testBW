using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "MainSearch", Title = "MainSearch", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner))]
    public class MainSearchController : Controller
    {

        public ActionResult Index()
        {

            return View("Default", new MainSearchModel());
        }

        [HttpPost]
        public ActionResult Index(MainSearchModel model)
        {

            return View("Default", new MainSearchModel());
        }
    }
}