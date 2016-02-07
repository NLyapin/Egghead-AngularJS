using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraniteWorld.Controllers
{
    public class EmployeePortalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Shell()
        {
            return PartialView();
        }

        public PartialViewResult TopNav()
        {
            return PartialView();
        }

        public PartialViewResult LoadInventory()
        {
            return PartialView();
        }
    }
}